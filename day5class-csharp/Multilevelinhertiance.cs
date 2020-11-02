using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
    class College
    {
      protected  string CollegeName = "Aditya";
    }
    class Department:College
    {
       protected string Deptname = "cse";
       protected void getdept()
        {
            Console.WriteLine("Collegename:{0}||Deptname:{1}", CollegeName, Deptname);

        }
    }
    class student:Department    
    {
        string Stuname = "Mani";
        void Displaystuinfo()
        {
            Console.WriteLine("stuname:{0}||Deptname:{1}||collegename:{2}", Stuname, Deptname,CollegeName);
        }
        static void Main()
        {
            student Student = new student();
            Student.getdept();
            Student.Displaystuinfo();
            Console.ReadKey();

        }
    }
    }
