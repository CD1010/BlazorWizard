using Microsoft.AspNetCore.Components;

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


        [Parameter]
        public bool Visible { get; set; } 

        public void SetVisible(bool isVisible)
        {
            Visible = isVisible;

        }

        public EventCallback<bool> VisibleChanged;
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

        protected override void OnParametersSet()
        {
 

            base.OnParametersSet();
        }

        protected override void OnInitialized()
        {
            Parent.AddStep(this);
                
        }
    }
}
