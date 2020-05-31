using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class StartBar : ComponentBase
    {
        [Inject] IJSRuntime JS { get; set; }

        [Parameter]
        public RenderFragment StartBarItems { get; set; }

        public void ShowDesktop(MouseEventArgs e)
        {
            JS.InvokeVoidAsync("JQD.interop.show_desktop");
        }
    }
}

