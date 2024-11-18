using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Logs
{
    public int Logid { get; set; }

    public DateTime Timestamp { get; set; }

    public string Loglevel { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Users { get; set; }

    public string? Action { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }
}
