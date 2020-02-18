using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CompleteAthlete : IUniversalAthlete
    {
        public void BackHand()
        {
            Console.WriteLine("Hitting with backhand");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        void ITennisPlayer.Exult()
        {
            Console.WriteLine("I'm a great tennis player!");
        }

        void ISkier.Exult()
        {
            Console.WriteLine("I'm the best Skier!");
        }

        public void ForeHand()
        {
            Console.WriteLine("Hitting with forehand");
        }

        public void Jump()
        {
            Console.WriteLine("Jumping");
        }

        public void Run()
        {
            Console.WriteLine("Running");
        }

        public void Ski()
        {
            Console.WriteLine("Skiing");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
