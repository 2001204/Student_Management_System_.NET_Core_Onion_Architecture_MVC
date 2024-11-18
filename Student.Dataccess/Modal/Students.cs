using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Students
{
    public int Studentid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly Dateofbirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phonenumber { get; set; } = null!;

    public int Addressid { get; set; }

    public int? Tempaddressid { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual Addresss Address { get; set; } = null!;

    public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

    public virtual ICollection<Fees> Fees { get; set; } = new List<Fees>();

    public virtual Tempaddresss? Tempaddress { get; set; }
}
