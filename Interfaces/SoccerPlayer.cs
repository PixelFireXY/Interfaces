using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SoccerPlayer : IAthlete, IComparable
    {
        private string name, surname, team;

        public int CompareTo(object obj)
        {
            if(obj is SoccerPlayer)
            {
                SoccerPlayer soccerPlayer = (SoccerPlayer)obj;

                if (name == soccerPlayer.name &&
                    surname == soccerPlayer.surname &&
                    team == soccerPlayer.team)
                    return 1;
            }

            return 0;
        }

        public void Jump()
        {
            Console.WriteLine("I'm jumping!");
        }

        public void Run()
        {
            Console.WriteLine("I'm running!");
        }
    }
}
