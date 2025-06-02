using System;
using System.Collections.Generic;

namespace AnalysisSample.Models;

public partial class DirectoryManagementMaster
{
    public string DirectoryName { get; set; } = null!;

    public bool SetDirectoryName { get; set; }

    public string? ParentDirecotry { get; set; }

    public string? TempDirectory { get; set; }
}
