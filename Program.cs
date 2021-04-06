using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Input input = new Input();
            Player player = new Player();
            int k = 1;
            try
            {
                while (true)
                {
                    board.ShowBoard();
                    Console.Write("Player {0} Turn: ", player.playerTurn);
                    while (!(board.BoardInput(input.NewInput = Console.ReadLine(), player.playerSign))) ;
                    #region
                    if (board.WinOrNot(player.playerSign, player.playerTurn))
                    {
                        board.ShowBoard();
                        Console.WriteLine("Player {0} Wins", player.playerTurn);
                        Console.WriteLine("Prees 1 To Reset or 2 to Exit the game.");
                        string choice = Console.ReadLine().ToString();
                        if(choice != "1" || choice != "2")
                            do
                            {
                                Console.WriteLine("Prees 1 To Reset or 2 to Exit the game.");
                                choice = Console.ReadLine().ToString();
                            } while (choice != "1" || choice != "1");

                        if (choice.Equals("2"))
                            break;
                        else if (choice.Equals("1") || k == 9)
                        {
                            if (k == 9)
                            {
                                Console.WriteLine("Its A Drew, No One Win");
                                k = 0;
                            }
                            board.ResetBoard();
                            player.playerTurn = 1;
                            continue;
                        }
                        
                    }
                    #endregion
                    player.TurnChange();
                    k++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
        }
    }
}
