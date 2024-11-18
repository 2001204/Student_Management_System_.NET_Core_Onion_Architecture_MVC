using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Fee
{
    internal class Fee
    {

        [Required(ErrorMessage = "Studentid is required")]
        public int Studentid { get; set; }

        [Required(ErrorMessage = "Courseid is required")]
        public int Courseid { get; set; }

        [Required(ErrorMessage = "Feeamount is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Feeamount must be a non-negative number")]
        public decimal Feeamount { get; set; }

        [Required(ErrorMessage = "Paymentdate is required")]
        public DateOnly Paymentdate { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual Courses Course { get; set; } = null!;

        public virtual Students Student { get; set; } = null!;
    }
}
