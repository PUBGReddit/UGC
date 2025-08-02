using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace PUBGReddit.UGC.App.DiagramWidget;

public class DeviceNode : NodeModel
{
    public DeviceNode(Point position, string deviceType) : base(position) { DeviceType = deviceType; }

    public string DeviceType { get; private set; }

}

public class DevicePort : PortModel
{
    public DevicePort(NodeModel parent, PortAlignment alignment, string label) : base(parent, alignment, null, null)
    {
        Label = label;
    }
    public string Label { get; set; }
 
 
}
