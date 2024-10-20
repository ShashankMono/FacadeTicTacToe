using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacede.Exceptions
{
    internal class IndexOutOfBoundException:Exception
    {
        public IndexOutOfBoundException(string message):base(message) { }
    }
}
