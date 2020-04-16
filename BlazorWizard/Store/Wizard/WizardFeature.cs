using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace BlazorWizard.Store.Wizard
{
    public class WizardFeature : Feature<WizardState>
    {
        public override string GetName()
        {
            return "Wizard";
        }

        protected override WizardState GetInitialState()
        {
            StepState [] stepStates = new StepState[]
            { 
                new StepState() { Visible = true },
                new StepState() { Visible = false },
                new StepState() { Visible = true }
            };
            
            List<StepState> states = new List<StepState>();
            states.AddRange(stepStates);

            return new WizardState(states);
        }
    }
}
