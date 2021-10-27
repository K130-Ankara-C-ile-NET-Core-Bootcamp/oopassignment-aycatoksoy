using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
    public class Car : ICarCommand, Interfaces.IObservable<CarInfo>

    {
        /*
- ICarCommand interface'ini implemente etmelidir
- IObservable<CarInfo> interface'ini implemente etmelidir
- Guid Id
- Coordinates Coordinates 
- Direction Direction 
- ISurface Surface 
- private IObserver<CarInfo> Observer
- Constructor(Coordinates coordinates, Direction direction, ISurface surface) 
- void TurnLeft() 
- void TurnRight() 
- void Move()  
- void Attach(IObserver<CarInfo> observer) 
- void Notify() 
*/
        public Guid Id;
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;

        private Interfaces.IObserver<CarInfo> Observer
        {
            get;
            set;
        }

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }


        public void TurnLeft()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.S;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.E;
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.W;
            }
            else
            {
                throw new Exception("invalid");

            }
            Notify();
        }

        public void TurnRight()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.E;
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.S;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.N;
            }
            else
            {
                throw new Exception("invalid");

            }
            Notify();
        }

        public void Move()
        {

            if (Direction == Direction.N)
            {
                Coordinates.Y = +1;
            }

            else if (Direction == Direction.E)
            {
                Coordinates.X = +1;
            }

            else if (Direction == Direction.S)
            {
                Coordinates.Y = -1;
            }

            else if (Direction == Direction.W)
            {
                Coordinates.X = -1;
            }

            else
            {
                throw new Exception("invalid");

            }
            Notify();

        }
        void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            Observer = observer;
            Notify();
        }


        public void Notify()
        {
            Observer.Update(new CarInfo(Id, Coordinates));

        }

        void Interfaces.IObservable<CarInfo>.Attach(Interfaces.IObserver<CarInfo> observer)
        {

        }
    }



}
