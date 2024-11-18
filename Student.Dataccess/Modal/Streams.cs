using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Streams
{
    public int Streamid { get; set; }

    public string Streamname { get; set; } = null!;

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<Courses> Courses { get; set; } = new List<Courses>();

    public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();
}
