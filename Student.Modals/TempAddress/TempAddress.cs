using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.TempAddress
{
    internal class TempAddress
    {

        public int Tempaddressid { get; set; }

        [Required(ErrorMessage = "Streetname is required")]
        public string Streetname { get; set; } = null!;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; } = null!;

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = "Zipcode is required")]
        [Range(10000, 99999, ErrorMessage = "Zipcode must be between 10000 and 99999")]
        public int Zipcode { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual ICollection<Students> Students { get; set; } = new List<Students>();
    }
}
