using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationtable
{
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(a + "*" + i + "= " + a * i);
            }
            int factorial(int x)
            {
                int ans = 1;
                while (x > 1)
                {
                    ans = ans * x;
                    x--;
                }
                return ans;
            }
            Console.WriteLine("the factorial of {0}",a);
            Console.WriteLine(factorial(a));

            }

        }
    }

