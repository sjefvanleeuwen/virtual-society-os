using Microsoft.AspNetCore.Components;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class Window
    {
        [Parameter] public string Handle { get; set; }
        [Parameter] public string Icon { get; set; }
        [Parameter] public int X { get; set; }
        [Parameter] public int Y { get; set; }
        [Parameter] public string Title { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Statusbar { get; set; }
    }
}
