using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PUBG.Reddit.UGC.Models
{
    // Define interfaces for common behaviors
    public interface ITargetable
    {
        TargetType Target { get; set; }
    }

    public interface IAreaBased
    {
        AreaShape AreaShape { get; set; }
        Vector3 AreaSize { get; set; }
    }

    public interface IActivatable
    {
        ActivationPhase ActivationPhase { get; set; }
    }
}
