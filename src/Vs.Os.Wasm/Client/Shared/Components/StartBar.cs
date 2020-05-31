using Microsoft.AspNetCore.Components;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class StartBar
    {
        [Parameter]
        public RenderFragment StartBarItems { get; set; }
    }
}
