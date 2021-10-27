using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;

namespace OOPAssignment.Interfaces
{
    public interface ISurface
    {
        /*
        - readonly long Width
		- readonly long Height
		- bool IsCoordinatesInBounds(Coordinates coordinates)
         */
        long Width
        {
            get;

        }

        long Height
        {
            get;

        }
        bool IsCoordinatesInBounds(Coordinates coordinates);



    }
}