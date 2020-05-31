using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class DesktopIcon : ComponentBase
    {
        [Inject] IJSRuntime JS { get; set; }
        [Parameter] public string Handle { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public string Icon { get; set; }
        [Parameter] public int X { get; set; }
        [Parameter] public int Y { get; set; }

        private ElementReference element;

        private async void ShowWindow(MouseEventArgs e)
        {
            await JS.InvokeVoidAsync("JQD.interop.icon_click", element);
        }
    }
}
