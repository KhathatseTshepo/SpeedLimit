using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    internal class Program
    {
        enum ZoneSpeed
        {
            SCHOOL = 20, CITY = 30, HIGHWAY = 55
        }
        enum Zones
        {
            SCHOOL = 1, CITY, HIGHWAY
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a zone Number\n1.School\n2.City\n3.Highway");
            int zone = Convert.ToInt32(Console.ReadLine());
            while (zone <= 0 || zone > 3)
            {
                Console.WriteLine("Please enter either 1, 2 or 3 only for each zone listed above");
                zone = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter your current speed");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (zone == 1 && speed > (int)ZoneSpeed.SCHOOL)
            {
                Console.WriteLine("Please slow down and maitain the speed limit of 20 in the School Zone");
            }
            else if (zone == 2 && speed > (int)ZoneSpeed.CITY)
            {
                Console.WriteLine("Please slow down and maitain the speed limit of 30 in the City Zone");
            }

            else if (zone == 3 && speed > (int)ZoneSpeed.HIGHWAY)
            {
                Console.WriteLine("Please slow down and maitain the speed limit of 20 in the 55 Zone");
            }
            else
            {
                Console.WriteLine("Thank you for maintaining the speed limit in your zone");
            }

            Console.ReadKey();
        }

    }
}
    
