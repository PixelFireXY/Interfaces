using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IUniversalAthlete : ISwimmer, ISkier, ITennisPlayer, IAthlete
    {
        void Eat();
        void Sleep();
    }
}
