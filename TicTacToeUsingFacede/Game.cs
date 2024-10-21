using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacede.Exceptions;

namespace TicTacToeUsingFacede
{
    internal class Game
    {
        private Player _player1;
        private Player _player2;
        private Board _board;
        private ResultAnalyzer _analyzer;
        public Game(Player player1,Player player2, Board board,ResultAnalyzer checkResult)
        {
            _player1 = player1;
            _player2 = player2;
            _board = board;
            _analyzer = checkResult;
        }

        public void TakeIndex(Player player)
        {
            Console.WriteLine($"Player {player.Mark} enter index(1-9) of cell to be marked");
            int index = int.Parse( Console.ReadLine() );
            if(index < 1 || index > 9)
            {
                throw new IndexOutOfBoundException("Index out of range");
            }
            try
            {
                _board.PlaceMark(index, player);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                TakeIndex(player);
            }
            
        }

        public void playGame()
        {
            bool counter = true;
            bool result = false;
            while (!_board.IsBoardFull())
            {
                result = Play(counter);
                if (result)
                    break;
                counter = !counter;
                _board.DisplayBoard();
            }
            if (!result)
                Console.WriteLine("\nMatch draw!\n");
                
            _board.DisplayBoard();
        }

        public bool Play(bool counter)
        {
            if (counter)
            {
                try
                {
                    TakeIndex(_player1);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Play(counter);
                    return false;
                }

                if (_analyzer.CheckWin(_board, _player1))
                    return true;
            }
            else
            {
                try
                {
                    TakeIndex(_player2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Play(counter);  
                    return false;
                }
                if (_analyzer.CheckWin(_board, _player2))
                    return true;

            }
            return false;
        }

    }
}
