using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Rolestores
{
    public int Roleid { get; set; }

    public string Rolename { get; set; } = null!;

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<Users> Users { get; set; } = new List<Users>();
}
