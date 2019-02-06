using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section_2_new
{

    class singh
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
            Console.ReadLine();

        }

        public static void MethodA()
        {
            while (Peanut())
            {

                Console.WriteLine("i is {0}", i);

                if (i > 10)
                {
                    return;
                }
            }
        }
        public static bool Peanut()
        {
            i++;
            return true;
        }
    }
}



