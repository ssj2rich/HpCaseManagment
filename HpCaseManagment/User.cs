using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpCaseManagment
{
    public class User
    {
        public string userName { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public bool isGrouppingEmails { get; set; }
        public string team { get; set; }

    }
}
