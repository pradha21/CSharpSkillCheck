using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager
    {
        private static object eID=0;
        private static object eName=null;
        private static object eLevel=0;
        private static object eDoJ=null;

        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(List<Employee> drEmployeesLst, string cCode) : base(eID, eName, eLevel, eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public Manager(int eID, string eName, int eLevel, DateTime dateTime, List<Employee> lstDirectReports, string eDoJ)
        {

        }
        

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}