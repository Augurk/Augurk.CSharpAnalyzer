﻿/*
 Copyright 2017, Augurk
 
 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at
 
 http://www.apache.org/licenses/LICENSE-2.0
 
 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
*/

using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;

namespace Augurk.CSharpAnalyzer.Collectors
{
    public class DefaultInvocationTreeCollector
    {
        private readonly List<MethodWrapper> _invocations = new List<MethodWrapper>();
        private readonly Dictionary<IMethodSymbol, MethodWrapper> _wrappers = new Dictionary<IMethodSymbol, MethodWrapper>(); 
        private readonly Stack<MethodWrapper> _currentStack = new Stack<MethodWrapper>();

        public bool IsAlreadyCollected(IMethodSymbol method)
        {
            return _wrappers.ContainsKey(method);
        }

        /// <summary>
        /// Called when a method is being stepped into.
        /// </summary>
        /// <param name="method">An <see cref="IMethodSymbol"/> describing the method that is being stepped into.</param>
        public void StepInto(IMethodSymbol method)
        {
            _currentStack.Push(Step(method));
        }

        /// <summary>
        /// Called when a method is being stepped out of.
        /// </summary>
        public void StepOut()
        {
            _currentStack.Pop();
        }

        /// <summary>
        /// Called when a method is being stepped over.
        /// </summary>
        /// <param name="method">An <see cref="IMethodSymbol"/> describing the method that is being stepped over.</param>
        public void StepOver(IMethodSymbol method)
        {
            Step(method);
        }

        public JToken GetJsonOutput()
        {
            return GetJsonOutput(_invocations);
        }

        private JToken GetJsonOutput(IEnumerable<MethodWrapper> invocations, Stack<MethodWrapper> invocationStack = null)
        {
            var output = new JArray();
            if (invocationStack == null)
            {
                invocationStack = new Stack<MethodWrapper>();
            }

            foreach (var invocation in invocations)
            {
                var jInvocation = new JObject();

                var kind = invocation.RegularExpressions.Length > 0 ?
                           "When" :
                           invocation.Method.DeclaredAccessibility.ToString();

                jInvocation.Add("Kind", kind);
                jInvocation.Add("Signature", $"{invocation.Method.ToDisplayString()}, {invocation.Method.ContainingAssembly.Name}");

                if (invocation.RegularExpressions.Length > 0)
                {
                    jInvocation.Add("RegularExpressions", new JArray(invocation.RegularExpressions));
                }

                if (!invocationStack.Contains(invocation))
                {
                    invocationStack.Push(invocation);
                    jInvocation.Add("Invocations", GetJsonOutput(invocation.Invocations, invocationStack));
                    invocationStack.Pop();
                }
                else
                {
                    jInvocation.Add("Note", "Recursive");
                }

                output.Add(jInvocation);
            }

            return output;
        }

        private MethodWrapper Step(IMethodSymbol method)
        {
            // Try to find a wrapper; otherwise, create one
            MethodWrapper wrapper;
            if (!_wrappers.TryGetValue(method, out wrapper))
            {
                wrapper = new MethodWrapper(method);
                _wrappers.Add(method, wrapper);
            }

            if (_currentStack.Count == 0)
            {
                _invocations.Add(wrapper);
            }
            else
            {
                _currentStack.Peek().Invocations.Add(wrapper);
            }

            return wrapper;
        }

        private class MethodWrapper
        {
            public IMethodSymbol Method { get; }

            public List<MethodWrapper> Invocations { get; } = new List<MethodWrapper>(); 

            public ImmutableArray<string> RegularExpressions { get; }

            public MethodWrapper(IMethodSymbol method)
            {
                Method = method;

                RegularExpressions = GetRegularExpressions();
            }

            private ImmutableArray<string> GetRegularExpressions()
            {
                return Method.GetAttributes()
                           .Where(attribute => attribute.AttributeClass.Name.EndsWith("WhenAttribute")
                                            && (attribute.ConstructorArguments.Length > 0
                                            || attribute.NamedArguments.Any(na => na.Key == "Regex")))
                           .Select(attribute => 
                                attribute.NamedArguments.FirstOrDefault(na => na.Key =="Regex").Value.Value?.ToString() ?? 
                                attribute.ConstructorArguments.First().Value.ToString())
                           .ToImmutableArray();
            }
        }
    }
}