using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class Subjects
{
    public int Subjectid { get; set; }

    public string Subjectname { get; set; } = null!;

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();
}
