using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Structs
{
    public struct MovementFactor
    {
        /*
        - int XFactor
		- int YFactor
		- Constructor(int xFactor, int yFactor)
         */
        public int XFactor;
        public int YFactor;

        public MovementFactor(int xFactor, int yFactor)
        { 
            this.XFactor = xFactor;
          this.YFactor = yFactor;
        }
    }
}
