using System;
using System.Collections.Generic;

namespace AnalysisSample.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string? FilePath { get; set; }

    public string? TagName { get; set; }
}
