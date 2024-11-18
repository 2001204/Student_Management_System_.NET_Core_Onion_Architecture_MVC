using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Enrollment
{
    internal class Enrollment
    {

        public int Enrollmentid { get; set; }

        [Required(ErrorMessage = "Studentid is required")]
        public int Studentid { get; set; }

        [Required(ErrorMessage = "Courseid is required")]
        public int Courseid { get; set; }

        [Required(ErrorMessage = "Enrollmentdate is required")]
        public DateOnly Enrollmentdate { get; set; }

        public int? Enrollmentnumber { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual Courses Course { get; set; } = null!;

        public virtual Students Student { get; set; } = null!;
    }
}
