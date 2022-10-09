using interfaceevaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceevaluation
{
    public interface Ivehicle
    {
         void drive();
        bool refuel(int amount);

    }
    public class car : Ivehicle
    {
       public int fuel = 0;
        public void drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("car is driving");
            }

        }
        public bool refuel(int a)
        {
            fuel = fuel + a;
            if (a > 0) { Console.WriteLine("fuel is there"); }
            
               
            
                return true;
            
        }
    }
    

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        car c = new car();
        c.refuel(Convert.ToInt32(Console.ReadLine()));
        c.drive();
        }
    }

