using day5class_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
    class Organization
    {
        protected string Orgnam = "LTI";
        protected string Location;
        internal void DisplayOrg()
        {
        Console.WriteLine("orgname:{0}||Location:{1}",Orgnam,Location);
        }
       }
class Employee:Organization
{
        int eid = 1001;
        float salary = 209800.03f;
        internal void Displayemployee()
        {
            Console.WriteLine("eid:{0}||salary:{1}||orgnam:{2}", eid, salary, Orgnam);
        }
        static void Main()
        {
            Employee employee = new Employee();
            employee.Location = "chennai";
            employee.DisplayOrg();
            employee.Displayemployee();
            Console.ReadKey();
        }

    }
}
