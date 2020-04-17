using BlazorWizard.Store.Wizard;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWizard.Store.Wizard
{
    public static class Reducers 
    {
        [ReducerMethod]
        public static  WizardState ReduceWizardAllOnAction(WizardState state, WizardAllOnAction action)
        {
            StepState[] stepStates = new StepState[]
           {
                new StepState() { Visible = true },
                new StepState() { Visible = true },
                new StepState() { Visible = true }
           };

            List<StepState> states = new List<StepState>();
            states.AddRange(stepStates);

            return new WizardState(states);
        }
        [ReducerMethod]
        public static WizardState ReduceWizardFirstOnAction(WizardState state, WizardFirstOnAction action)
        {
            StepState[] stepStates = new StepState[]
           {
                new StepState() { Visible = true },
                new StepState() { Visible = false },
                new StepState() { Visible = false }
           };

            List<StepState> states = new List<StepState>();
            states.AddRange(stepStates);

            return new WizardState(states);
        }
    }
}
