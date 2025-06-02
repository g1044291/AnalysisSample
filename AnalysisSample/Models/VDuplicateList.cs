using System;
using System.Collections.Generic;

namespace AnalysisSample.Models;

public partial class VDuplicateList
{
    public string? FilePath { get; set; }

    public TimeOnly? VideoTime { get; set; }

    public decimal? Size { get; set; }

    public int? Count { get; set; }
}
