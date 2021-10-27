using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Structs
{
    public struct Coordinates
    {
        /*
        - long X
		- long Y
		- Constructor(long x, long y)
         */

        public long X;
        public long Y;

        public Coordinates(long x, long y)
        {
            this.X=  x;
            this.Y = y;

        }

    }
}
