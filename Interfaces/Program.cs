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
            CompleteAthlete athlete = new CompleteAthlete();

            ((ISkier)athlete).Exult();
            ((ITennisPlayer)athlete).Exult();

            athlete.Jump();

            Console.ReadLine();
        }
    }
}
