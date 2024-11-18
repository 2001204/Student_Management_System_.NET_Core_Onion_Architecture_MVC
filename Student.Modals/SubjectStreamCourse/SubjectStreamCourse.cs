using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.SubjectStreamCourse
{
    internal class SubjectStreamCourse
    {

        public int Streamid { get; set; }

        public int Courseid { get; set; }

        public virtual Courses Course { get; set; } = null!;

        public virtual Streams Stream { get; set; } = null!;

        public virtual Subjects Subject { get; set; } = null!;
    }
}
