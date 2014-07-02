using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //call any random number
            DigitalRoot("31675927325924794275176417492575491974297527462157942742195113232312279989446623110");
            
            Console.ReadKey();
        }

        static void DigitalRoot(string rootThis)
        {
            {
                var list = new List<int>() { };
                var answer = 0;

                for (int i = 0; i < rootThis.Count(); i++)
                {   //converting our string to an integer
                    list.Add(Convert.ToInt32(rootThis[i].ToString()));
                    answer = list[i] += answer;
                }

                Console.WriteLine(answer);

                Console.WriteLine();

                //printing the process into the console
                if (answer.ToString().Length > 1)
                {   
                    DigitalRoot(answer.ToString());
                }
                else
                {
                    End();
                }
            }
        }

        static void End()
        {
            Console.WriteLine("Press any key to continue...");
            
            Console.WriteLine();
        }
    }
}