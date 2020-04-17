using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWizard.Store
{
    public class StepState
    {
        public bool Visible { get; set; }

    }
    public class WizardState
    {
        public List<StepState> States { get; private set; }
        public WizardState(List<StepState> states)
        {
            States = states;
        }
    }
}
