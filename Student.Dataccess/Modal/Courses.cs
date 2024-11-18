using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Courses
{
    public int Courseid { get; set; }

    public string Coursename { get; set; } = null!;

    public int Streamid { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

    public virtual ICollection<Fees> Fees { get; set; } = new List<Fees>();

    public virtual Streams Stream { get; set; } = null!;

    public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();
}
