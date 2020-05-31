using Microsoft.AspNetCore.Components;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class StartBarItem
    {
        [Parameter] public string Handle { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public string Icon { get; set; }
    }
}
