﻿using Cucumis.Specifications.Support;
using TechTalk.SpecFlow;

namespace Cucumis.Specifications.Steps
{
    [Binding]
    internal sealed class InheritanceSteps
    {
        [When("entrypoint is invoked on inherited automation class")]
        public void WhenEntrypointIsInvokedOnInheritedAutomationClass()
        {
            // The InheritedGardener is defined within the test namespace
            new InheritedGardener().PlantGherkin();
        }

        [When("entrypoint is invoked through an inherited automation class")]
        public void WhenEntrypointIsInvokedThroughAnInheritedAutomationClass()
        {
            // The InheritedGardener is so much more efficient
            new InheritedGardener().PlantGherkinAndWaterIt();
        }
    }
}