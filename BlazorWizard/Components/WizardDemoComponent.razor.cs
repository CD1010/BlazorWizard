using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWizard.Components
{
    public partial class WizardDemoComponent
    {
        public Wizard TheWiz { set; get; }
        Task _task;
        protected override void OnInitialized()
        {

        }
        protected override void OnParametersSet()
        {

            StateHasChanged();
            _task = Task.CompletedTask;
            base.OnParametersSet();
        }
    }
}
