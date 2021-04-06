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
            //Initializing Objects
            Board board = new Board();
            Input input = new Input();
            Player player = new Player();
            int k = 1;
            try
            {
                //Game Loop
                while (true)
                {
                    //Refreshing board
                    board.ShowBoard();
                    Console.Write("Player {0} Turn: ", player.playerTurn);

                    //Check input on board (Insert sign or return false)
                    while (!(board.BoardInput(input.NewInput = Console.ReadLine(), player.playerSign))) ;

                    //Check Game Status Or Show After Game Options
                    #region
                    if (board.WinOrNot(player.playerSign, player.playerTurn))
                    {
                        board.ShowBoard();
                        Console.WriteLine("Player {0} Wins", player.playerTurn);
                        Console.Write("Prees 1 To Reset or 2 to Exit the game:");
                        string choice = Console.ReadLine().ToString();
                        while (choice != "1" && choice != "2") 
                        {
                                Console.Write("Prees 1 To Reset or 2 to Exit the game:");
                                choice = Console.ReadLine().ToString();
                        } 

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
