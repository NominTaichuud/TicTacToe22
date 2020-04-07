using System;
using TicTacToeAndOthello2.Properties;

namespace TicTacToeAndOthello2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            Game game = new Game(board);
            CheckWin checkWin = new CheckWin();
            UI ui = new UI();
            
            ui.introduction();
            

            while (game.PlaysAgain.Equals("Y"))
            {

                board.initializeVariable();
                while(checkWin.hasWon(board.currentBoard)==false && game.Counter < 9)
                {
                    game.askData("X");
                    if (checkWin.hasWon(board.currentBoard) == true || game.Counter == 9)
                        break;
                    game.askData("O");
                }
                if (checkWin.hasWon(board.currentBoard) == true)
                {
                    ui.playAgainMsg("Congradulation! You won!");
                }
                else
                    ui.playAgainMsg("Sorry, but this was a tie game!");
                
            }
            ui.goodBye();
        }
    }
}
