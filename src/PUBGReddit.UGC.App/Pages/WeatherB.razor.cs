using Blazor.Diagrams;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Controls.Default;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.PathGenerators;
using Blazor.Diagrams.Core.Positions;
using Blazor.Diagrams.Core.Routers;
using Microsoft.AspNetCore.Components;
using PUBGReddit.UGC.App.DiagramWidget;

namespace PUBGReddit.UGC.App.Pages
{
    public class WeatherComponent : ComponentBase
    {
        protected readonly BlazorDiagram BlazorDiagram = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            BlazorDiagram.RegisterComponent<DeviceNode, DeviceWidget>();
            var node1 = NewDeviceNode(50, 50);
            var node2 = NewDeviceNode(300, 300);
            var node3 = NewDeviceNode(300, 50);
            BlazorDiagram.Nodes.Add(node1);
            BlazorDiagram.Nodes.Add(node2);
            BlazorDiagram.Nodes.Add(node3);

            var Link1 = new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Left))
            {
                Router = new NormalRouter(),
                PathGenerator = new StraightPathGenerator(),
                SourceMarker = LinkMarker.Arrow,
                TargetMarker = LinkMarker.Arrow
            };
            var Link2 = new LinkModel(node2.GetPort(PortAlignment.Right), node3.GetPort(PortAlignment.Left))
            {
                Router = new NormalRouter(),
                PathGenerator = new StraightPathGenerator(),
                SourceMarker = LinkMarker.Arrow,
                TargetMarker = LinkMarker.Arrow
            };

            BlazorDiagram.Links.Add(Link1);
            BlazorDiagram.Links.Add(Link2);

            BlazorDiagram.Controls.AddFor(Link1)
            .Add(new RemoveControl(new LinkPathPositionProvider(0.1))) ;

                        BlazorDiagram.Controls.AddFor(Link2) 
            .Add(new ArrowHeadControl(true))
            .Add(new ArrowHeadControl(false));
        }

        protected void ToggleZoom() => BlazorDiagram.Options.Zoom.Enabled = !BlazorDiagram.Options.Zoom.Enabled;

        protected void TogglePanning() => BlazorDiagram.Options.AllowPanning = !BlazorDiagram.Options.AllowPanning;

        protected void ToggleVirtualization()
            => BlazorDiagram.Options.Virtualization.Enabled = !BlazorDiagram.Options.Virtualization.Enabled;

        
          private NodeModel NewDeviceNode(double x, double y)
        {
            var node = new DeviceNode(new Point(x, y)); 
            node.AddPort(PortAlignment.Left);
            node.AddPort(PortAlignment.Right);
            return node;
        }
    }
}
