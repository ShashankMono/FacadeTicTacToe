using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacede.Exceptions
{
    internal class AlreadyMarkedEception:Exception
    {
        public AlreadyMarkedEception(string message) : base(message) { }
    }
}
