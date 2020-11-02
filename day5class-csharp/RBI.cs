using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
    abstract class RBI
    {
        int empo = 20;
        public abstract int Homeloan();
        public abstract int Educationloan();
        internal void Rbiemployee()
        {
            Console.WriteLine("Rbi Employee details:{0}", empo);
        }
    }
        class SBI:RBI
        {
        public override int Homeloan()
        {
            return 9;
        }
        public override int Educationloan()
        {
            return 10;

        }

    }
    class HDFC : RBI
    {
        public override int Homeloan()
        {
            return 10;
        }
        public override int Educationloan()
        {
            return 11;
        }
    }
    class Abstractioneg
    {
        static void Main()
        {
            /* SBI sbi = new SBI();
             sbi.Rbiemployee();
             Console.WriteLine("sbi h loan:{0}", sbi.Homeloan());
             Console.WriteLine("sbi h loan:{1}", sbi.Educationloan());
             HDFC hdfc = new HDFC();
             Console.WriteLine("hdfc h loan:{0}", hdfc.Homeloan()); 
             Console.WriteLine("hdfc h loan:{1}", hdfc.Educationloan());*/
            RBI r;
            r = new SBI();
            r.Rbiemployee();
            Console.WriteLine("sbi h loan:{0}", r.Homeloan());
            Console.WriteLine("sbi h loan:{1}", r.Educationloan());
            r = new HDFC();
            Console.WriteLine("sbi h loan:{0}", r.Homeloan());
            Console.WriteLine("sbi h loan:{1}", r.Educationloan());
            Console.Read();


        }
    }
}

   
