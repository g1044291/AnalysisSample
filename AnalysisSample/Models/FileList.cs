using System;
using System.Collections.Generic;

namespace AnalysisSample.Models;

public partial class FileList
{
    public int Id { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string? ThumbnailPath { get; set; }

    public string? DirectoryName { get; set; }

    public string? Extension { get; set; }

    public bool? IsMovie { get; set; }

    public bool? IsImage { get; set; }

    public bool? IsUnorganized { get; set; }

    public decimal? Size { get; set; }

    public TimeOnly? VideoTime { get; set; }

    public int? ViewsCount { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsFavorite { get; set; }
}
