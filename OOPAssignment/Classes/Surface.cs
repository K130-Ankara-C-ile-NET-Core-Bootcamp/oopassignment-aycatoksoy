using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {
        /*
- ISurface interface'ini implemente etmelidir ++++
- ICollidableSurface interface'ini implemente etmelidir +++
- IObserver<CarInfo> interface'ini implemente etmelidir ++++
- long Width ++
- long Height ++
- private readonly List<CarInfo> ObservableCars ++
- Constructor(long width, long height) ++ 
- bool IsCoordinatesInBounds(Coordinates coordinates) ++ 
- bool IsCoordinatesEmpty(Coordinates coordinates) ++
- void Update(CarInfo provider)
- List<CarInfo> GetObservables()
*/

        public long _width;
        public long _height;

        public Surface(long width, long height)
        {
            _width = width;
            _height = height;
            ObservableCars = new List<CarInfo>();
        }

        private readonly List<CarInfo> ObservableCars;


        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            while (ObservableCars != null)
            {
                foreach (var observedcar in ObservableCars)
                {
                    if (observedcar.Coordinates.X == coordinates.X
                        && observedcar.Coordinates.Y == coordinates.Y)
                        return false;
                }
            }

            return true;
        }



        public void Update(CarInfo provider)
        {
            CarInfo car = ObservableCars.FirstOrDefault(x => x.CarId == provider.CarId);
            if (GetObservables().Contains(provider))
            {
                car.Coordinates = provider.Coordinates;
            }
            else if (IsCoordinatesEmpty(provider.Coordinates)
                     || car.Coordinates.X != provider.Coordinates.X
                     || car.Coordinates.Y != provider.Coordinates.Y
                     )
            {
                ObservableCars.Add(provider);
            }

            else
            {
                throw new Exception("invalid");
            }

        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            bool coordinatesInBounds;

            if (coordinates.X >= 0 && coordinates.X <= Width &&
                coordinates.Y >= 0 && coordinates.Y <= Height)
            {
                coordinatesInBounds = true;
            }

            else
            {
                coordinatesInBounds = false;
            }

            return coordinatesInBounds;

        }

        public List<CarInfo> GetObservables()
        {
            List<CarInfo> list = new List<CarInfo>();

            while (ObservableCars != null)
            {

                foreach (var item in ObservableCars)
                {
                    list.Add(item);
                }

                return list;
            }

            throw new Exception("invalid");
        }

    }
}
