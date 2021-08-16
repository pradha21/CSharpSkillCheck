using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        private static object eID;
        private static object eName;
        private static object eLevel;
        private static object eDoJ;

       

        public DirectReport(Employee managerEmpObj, string pCode) : base(eID, eName, eLevel, eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

        public DirectReport(int eID, string eName, int eLevel, DateTime dateTime, object p, string eDoJ)
        {
        }
    }
}
