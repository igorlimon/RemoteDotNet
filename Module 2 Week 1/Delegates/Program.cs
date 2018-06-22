using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        class Room
        {
            public delegate void AprindeLumina();

            public event AprindeLumina ApprindeLumina;
        }

        static void Main(string[] args)
        {
            var r = new Room();
            r.
        }
    }
}
