using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    internal interface IBomb
    {
        int b { get; set; }
        int c { get; set; }
        int d { get; set; }
        int e { get; set; }
        int f { get; set; }


        void Cast();
    }
}
