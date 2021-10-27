using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
     public class CarInfo
    {
        /*
        - Guid CarId
		- Coordinates Coordinates
		- Constructor(Guid carId, Coordinates coordinates)
         */

        public Guid CarId;
      

        public Coordinates Coordinates;
        

        public CarInfo(Guid carId, Coordinates coordinates)
        {
            CarId = carId;
            Coordinates = coordinates;
        }
    }
}
