using Microsoft.AspNetCore.Components;

namespace Vs.Os.Wasm.Shared.Components
{
    public partial class DesktopIcon
    {
        [Parameter] public string Handle { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public string Icon { get; set; }
        [Parameter] public int X { get; set; }
        [Parameter] public int Y { get; set; }
    }
}
