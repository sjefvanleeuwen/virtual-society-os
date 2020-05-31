using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class Window
    {
        [Inject] IJSRuntime JS { get; set; }
        [Parameter] public string Handle { get; set; }
        [Parameter] public string Icon { get; set; }
        [Parameter] public int X { get; set; }
        [Parameter] public int Y { get; set; }
        [Parameter] public string Title { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Statusbar { get; set; }

        private ElementReference element;

        private async void FocusWindow(MouseEventArgs e)
        {
            await JS.InvokeVoidAsync("JQD.interop.focus_window", element);
        }
    }
}
