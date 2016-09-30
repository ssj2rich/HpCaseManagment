using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpCaseManagment
{
    public class Case
    {
        public User user { get; set; }
        public string caseId { get; set; }
        public string caseAge { get; set; }
        public string daysSinceLastActivity { get; set; }

    }
}
