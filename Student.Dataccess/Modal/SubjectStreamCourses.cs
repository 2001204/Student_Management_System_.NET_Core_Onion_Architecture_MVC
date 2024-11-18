using System;
using System.Collections.Generic;

namespace Student.Dataccess.Modal;

public partial class SubjectStreamCourses
{
    public int Subjectid { get; set; }

    public int Streamid { get; set; }

    public int Courseid { get; set; }

    public virtual Courses Course { get; set; } = null!;

    public virtual Streams Stream { get; set; } = null!;

    public virtual Subjects Subject { get; set; } = null!;
}
