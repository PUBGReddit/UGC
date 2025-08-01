using Blazor.Diagrams;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.PathGenerators;
using Blazor.Diagrams.Core.Routers;
using Microsoft.AspNetCore.Components;

namespace PUBGReddit.UGC.App.Pages
{
    public class WeatherComponent : ComponentBase
    {
       protected readonly BlazorDiagram BlazorDiagram = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var node1 = NewNode(50, 50);
            var node2 = NewNode(300, 300);
            var node3 = NewNode(300, 50);
            BlazorDiagram.Nodes.Add(node1);
            BlazorDiagram.Nodes.Add(node2);
            BlazorDiagram.Nodes.Add(node3);

            BlazorDiagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), node2.GetPort(PortAlignment.Left))
            {
                SourceMarker = LinkMarker.Arrow,
                TargetMarker = LinkMarker.Arrow
            });
            BlazorDiagram.Links.Add(new LinkModel(node2.GetPort(PortAlignment.Right), node3.GetPort(PortAlignment.Right))
            {
                Router = new OrthogonalRouter(),
                PathGenerator = new StraightPathGenerator(),
                SourceMarker = LinkMarker.Arrow,
                TargetMarker = LinkMarker.Arrow
            });
        }

        protected void ToggleZoom() => BlazorDiagram.Options.Zoom.Enabled = !BlazorDiagram.Options.Zoom.Enabled;

        protected void TogglePanning() => BlazorDiagram.Options.AllowPanning = !BlazorDiagram.Options.AllowPanning;

        protected void ToggleVirtualization()
            => BlazorDiagram.Options.Virtualization.Enabled = !BlazorDiagram.Options.Virtualization.Enabled;

        private NodeModel NewNode(double x, double y)
        {
            var node = new NodeModel(new Point(x, y));
            node.AddPort(PortAlignment.Bottom);
            node.AddPort(PortAlignment.Top);
            node.AddPort(PortAlignment.Left);
            node.AddPort(PortAlignment.Right);
            return node;
        }
    }
}
