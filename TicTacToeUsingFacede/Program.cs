namespace TicTacToeUsingFacede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player _player1 = new Player(MarkType.X);
            Player _player2 = new Player(MarkType.O);
            Board _board = new Board();
            ResultAnalyzer _analyzer = new ResultAnalyzer();

            Game game = new Game(_player1,_player2,_board,_analyzer);

            game.playGame();
        }
    }
}
