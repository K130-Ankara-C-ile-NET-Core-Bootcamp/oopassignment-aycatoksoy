using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;

namespace OOPAssignment.Classes
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        /*
        - CarCommandExecutorBase'i extend etmelidir
		- IStringCommand interface'ini implemente etmelidir
		- void ExecuteCommand(string commandObject)
         */

        public Car car;

        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {

        }

        public void ExecuteCommand(string commandObject)
        {
            while (string.IsNullOrWhiteSpace(commandObject))
            {
                throw new Exception();
            }

            foreach (var item in commandObject)
            {
                if (item == 'R')
                {
                    CarCommand.TurnRight();
                }
                if (item == 'L')
                {
                    CarCommand.TurnLeft();
                }
                if (item == 'M')
                {
                    CarCommand.Move();
                }
                else
                {
                    throw new Exception();
                }
            }

        }

        
    }

}
