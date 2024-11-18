using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Student
{
    internal class Student
    {
        public int Studentid { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; } = null!;

        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; } = null!;

        [Required(ErrorMessage = "Dateofbirth is required")]
        public DateOnly Dateofbirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phonenumber is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phonenumber { get; set; } = null!;

        [Required(ErrorMessage = "Addressid is required")]
        public int Addressid { get; set; }

        public int? Tempaddressid { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual Addresss Address { get; set; } = null!;

        public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

        public virtual ICollection<Fees> Fees { get; set; } = new List<Fees>();

        public virtual Tempaddresss? Tempaddress { get; set; }


    }
}
