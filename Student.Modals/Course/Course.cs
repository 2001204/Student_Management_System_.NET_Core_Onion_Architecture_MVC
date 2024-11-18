using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Course
{
    internal class Course
    {


        public int Courseid { get; set; }

        [Required(ErrorMessage = "Coursename is required")]
        public string Coursename { get; set; } = null!;

        [Required(ErrorMessage = "Streamid is required")]
        public int Streamid { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

        public virtual ICollection<Fees> Fees { get; set; } = new List<Fees>();

        [Required(ErrorMessage = "Stream is required")]
        public virtual Streams Stream { get; set; } = null!;

        public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();
    }
}
