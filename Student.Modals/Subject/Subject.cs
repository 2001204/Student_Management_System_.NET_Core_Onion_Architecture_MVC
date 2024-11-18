using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Subject
{
    internal class Subject
    {

        public int Subjectid { get; set; }

        [Required(ErrorMessage = "Subjectame is required")]

        public string Subjectname { get; set; } = null!;

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual ICollection<SubjectStreamCourses> SubjectStreamCourses { get; set; } = new List<SubjectStreamCourses>();
    }
}
