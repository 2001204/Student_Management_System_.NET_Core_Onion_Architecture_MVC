using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Modals.Log
{
    internal class Log
    {

        public int Logid { get; set; }

        public DateTime Timestamp { get; set; }

        public string Loglevel { get; set; } = null!;

        public string Message { get; set; } = null!;

        public string? Users { get; set; }

        public string? Action { get; set; }

        public string? Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        public string? Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }
    
}
}
