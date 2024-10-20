using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacede.Exceptions;

namespace TicTacToeUsingFacede
{
    internal class Board
    {
        public Cell[] cells = new Cell[9];

        public bool IsBoardFull()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i] == null)
                {
                    return false;
                }
                
            }
            return true;
        }

        public void PlaceMark(int index , Player player)
        {
            if (cells[index-1] == null)
            {
                cells[index-1] = new Cell(player.Mark);
            }else if (cells[index-1].IsCellEmpty())
            {
               player.Mark = cells[index-1].GetMark() ;
            }
            else
            {
                throw new AlreadyMarkedEception("The cell is already marked");
            }
            
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < 9; i+=3) {
                string first = cells[i] == null ? " " : cells[i].GetMark().ToString();
                string second = cells[i+1] == null ? " " : cells[i+1].GetMark().ToString();
                string third = cells[i+2] == null ? " " : cells[i+2].GetMark().ToString();
                Console.WriteLine($"{first} | {second} | {third}\n" +
                    $"----------");
            }
        }
    }
}
