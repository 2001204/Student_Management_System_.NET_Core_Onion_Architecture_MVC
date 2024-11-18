using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Rolestore
{
    internal class Rolestore
    {


        public int Roleid { get; set; }

        [Required(ErrorMessage = "Rolename is required")]

        public string Rolename { get; set; } = null!;

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public virtual ICollection<Users> Users { get; set; } = new List<Users>();
    }
}
