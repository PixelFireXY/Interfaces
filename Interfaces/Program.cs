using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the class CompleteAthlete
            CompleteAthlete athlete = new CompleteAthlete();

            //base on the cast of the athlete, we can get different results for the method called in the same way
            ((ISkier)athlete).Exult();
            ((ITennisPlayer)athlete).Exult();

            //also you can call normally the implemented interfaces
            athlete.Jump();

            Console.ReadLine();
        }
    }
}
