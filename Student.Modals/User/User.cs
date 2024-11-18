using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.User
{
    internal class User
    {

        public int Userid { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Roleid is required")]
        public int Roleid { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public virtual Rolestores Role { get; set; } = null!;
    }
}
