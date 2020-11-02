using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5class_csharp
{
        class AICTE
        {
            protected string standard = " student with above 50% aggregate";
        }
        class JUTUK : AICTE
        {
            int collegeid = 101;
            int seats = 150;
            internal void JNTUKDetails()
            {
                Console.WriteLine("collegeid{0},seat:{1},standard{2}",
                    collegeid, seats, standard);
            }
        }
        class JNTUH : AICTE
        {
            int collegeid = 102;
            int seats = 100;
            void JNTUHDetails()
            {
                Console.WriteLine("collegeid{0},seat:{1},standard{2}",
                    collegeid, seats, standard);
            }
            static void Main()
            {
                JNTUH jntuh = new JNTUH();
                jntuh.JNTUHDetails();
                JUTUK jntuk = new JUTUK();
                jntuk.JNTUKDetails();
                Console.Read();
            }

        }
    }
 

