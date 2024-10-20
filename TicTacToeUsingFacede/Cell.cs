using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacede
{
    internal class Cell
    {
        private MarkType Mark = MarkType.EMPTY;

        public Cell(MarkType mark)
        {
            Mark = mark;
        }

        public  void SetMark(MarkType mark)
        {
            Mark = mark;
        }

        public MarkType GetMark()
        {
            return Mark;
        }

        public bool IsCellEmpty()
        {
            if(Mark == MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
    }
}
