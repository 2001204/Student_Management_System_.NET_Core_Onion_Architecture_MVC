using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Addresss
{
    public int Addressid { get; set; }

    public string Streetname { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int Zipcode { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<Students> Students { get; set; } = new List<Students>();
}
