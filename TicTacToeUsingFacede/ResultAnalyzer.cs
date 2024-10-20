using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacede
{
    internal class ResultAnalyzer
    {
        private Board _board;
        private Player _player;
        public bool CheckFirstRow()
        {
            if (_board.cells[0] != null && _board.cells[1] != null && _board.cells[2] != null)
            {
                if (_board.cells[0].GetMark() == _player.Mark && _board.cells[1].GetMark() == _board.cells[0].GetMark() && _board.cells[1].GetMark() == _board.cells[2].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }
            return false;
        }

        public bool CheckSecondRow()
        {
            if (_board.cells[3] != null && _board.cells[4] != null && _board.cells[5] != null)
            {
                if (_board.cells[3].GetMark() == _player.Mark && _board.cells[3].GetMark() == _board.cells[4].GetMark() && _board.cells[4].GetMark() == _board.cells[5].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }
            return false;
        }

        public bool CheckThirdRow()
        {
            if(_board.cells[6] != null && _board.cells[7] != null && _board.cells[8] != null)
            {
                if (_board.cells[6].GetMark() == _player.Mark && _board.cells[6].GetMark() == _board.cells[7].GetMark() && _board.cells[7].GetMark() == _board.cells[8].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }
            
            return false;
        }

        public bool CheckFirstColumn()
        {
            if(_board.cells[0] != null && _board.cells[3] != null && _board.cells[6] != null)
            {
                if (_board.cells[0].GetMark() == _player.Mark && _board.cells[0].GetMark() == _board.cells[3].GetMark() && _board.cells[3].GetMark() == _board.cells[6].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }
                
            return false;
        }

        public bool CheckSecondColumn()
        {
            if (_board.cells[1] != null && _board.cells[4] != null && _board.cells[7] != null)
            {
                if (_board.cells[1].GetMark() == _player.Mark && _board.cells[1].GetMark() == _board.cells[4].GetMark() && _board.cells[4].GetMark() == _board.cells[7].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }

            return false;
        }

        public bool CheckThirdColumn()
        {
            if(_board.cells[2] != null && _board.cells[5] != null && _board.cells[8] != null)
            {
                if (_board.cells[2].GetMark() == _player.Mark && _board.cells[5].GetMark() == _board.cells[2].GetMark() && _board.cells[5].GetMark() == _board.cells[8].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }

            return false;
        }

        public bool CheckLeftDiagonal()
        {
            if(_board.cells[0] != null && _board.cells[4] != null && _board.cells[8] != null)
            {
                if (_board.cells[0].GetMark() == _player.Mark && _board.cells[0].GetMark() == _board.cells[4].GetMark() && _board.cells[4].GetMark() == _board.cells[8].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }

            return false;
        }

        public bool CheckRightDiagonal()
        {
            if (_board.cells[2] != null && _board.cells[4] != null && _board.cells[6] != null)
            {
                if (_board.cells[2].GetMark() == _player.Mark && _board.cells[2].GetMark() == _board.cells[4].GetMark() && _board.cells[4].GetMark() == _board.cells[6].GetMark())
                {
                    Console.WriteLine($"Player {_player.Mark} Win!");
                    return true;
                }
            }

            return false;
        }

        public bool CheckWin(Board board, Player player)
        {
            _board = board;
            _player = player;
            if (CheckFirstColumn()
                || CheckSecondColumn()
                || CheckThirdColumn()
                || CheckFirstRow()
                || CheckSecondRow()
                || CheckThirdRow()
                || CheckLeftDiagonal()
                || CheckRightDiagonal())
                return true;

            return false;
        }
    }
}
