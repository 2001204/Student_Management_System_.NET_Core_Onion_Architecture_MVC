using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Fees
{
    public int Feeid { get; set; }

    public int Studentid { get; set; }

    public int Courseid { get; set; }

    public decimal Feeamount { get; set; }

    public DateOnly Paymentdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual Courses Course { get; set; } = null!;

    public virtual Students Student { get; set; } = null!;
}
