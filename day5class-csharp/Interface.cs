using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
    interface INormalcalculator
    {
        int Add(int a, int b);
        string calcName;

    }
    class Computing : INormalcalculator, Iscientificcalcluator
    {
        internal string GetName()
        {
            return "Computing";
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        string INormalcalculator.CalcName()
        {
            
            return "INormalcalculator";
        }
        string Iscientificcalcluator.calcname()
        {
            return "Iscientificcalcluator";
        }
        class Interface
        {
            static void Main()
            {
                Computing computing = new Computing();
                Console.WriteLine("Addition:{0}", computing.Add(93,87));
                Console.WriteLine("class Name:{0}", computing.GetName());
                Iscientificcalcluator s = new Computing();
                Console.WriteLine(s.calcname());
                INormalcalculator r = new Computing();
                Console.WriteLine(r.calcname());
                Console.ReadKey();

            }
        }
    }

}
