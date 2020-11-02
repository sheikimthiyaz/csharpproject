using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
    class Car:Parts
    {
        static void Main()
        {
            Car c = new Car();
            c.Wheel = 4;
            c.Motor = "v6";
            c.DisplayParts();
            Console.Read();
        }
        
    }
    
   
}
