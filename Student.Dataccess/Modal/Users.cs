using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Users
{
    public int Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Roleid { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public virtual Rolestores Role { get; set; } = null!;
}
