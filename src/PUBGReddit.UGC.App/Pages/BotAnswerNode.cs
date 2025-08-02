using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace PUBGReddit.UGC.App.Pages;

public class BotAnswerNode : NodeModel
{
    public BotAnswerNode(Point position, string deviceType) : base(position) { DeviceType = deviceType; }

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
