using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;

namespace OOPAssignment.Classes
{
    public class CarCommandExecutorBase
    {
        /*
        - protected readonly ICarCommand CarCommand 
		- Constructor(ICarCommand carCommand)
         */

        protected ICarCommand CarCommand
        {
            get;
        }

        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            CarCommand = carCommand;
        }
    }
}