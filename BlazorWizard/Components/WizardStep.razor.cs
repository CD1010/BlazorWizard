using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorWizard.Components
{
    /// <summary>
    /// Wizard Step component
    /// </summary>
    public partial class WizardStep
    {
        /// <summary>
        /// The <see cref="Wizard"/> container
        /// </summary>
        [CascadingParameter]
        protected internal Wizard Parent { get; set; }

        /// <summary>
        /// The Child Content of the current <see cref="WizardStep"/>
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// The Name of the step
        /// </summary>
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public bool Enabled { get; set; }

        [Parameter]
        public EventCallback<bool> EnabledChanged { get; set; }

        public  Task OnEnableChanged(bool enabled)
        {
            return EnabledChanged.InvokeAsync(enabled);
        }
        protected override void OnInitialized()
        {
            
            Parent.AddStep(this);
        }
        protected override void OnParametersSet()
        {
   
            base.OnParametersSet();
        }
    }
}
