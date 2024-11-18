using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Stream
{
    internal class Stream
    {
        public int Streamid { get; set; }

        [Required(ErrorMessage = "Streamname is required")]
        public string Streamname { get; set; } = null!;

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual ICollection<Courses> Courses { get; set; } = new List<Courses>();

        public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();

    }
}
