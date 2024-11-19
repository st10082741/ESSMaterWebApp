using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class MediaContent
{
    public int MediaId { get; set; }

    public string MediaTitle { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public string Url { get; set; } = null!;
}
