using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private string[,] NewBoard = {{"1","2","3" },{"4","5","6" },{ "7","8","9"}};
        private string[] Check = new string[9];
        public Board()
        {
            Console.WriteLine("Board been Created");
        }
        public string GetNewBoard(int i,int j) {
           return this.NewBoard[i,j];
        }
        public void SetNewBoard(string value,int i,int j)
        {
           this.NewBoard[i, j] = value;
        }
        public void ShowBoard() {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (!(j == 2))
                        Console.Write(" {0} |", NewBoard[i, j]);
                    else
                        Console.WriteLine(" {0}", NewBoard[i, j]);
                if (!(i == 2))
                    Console.WriteLine(" ---------");
            }
        }
        public bool BoardInput(string value, string sign)
        {
            if (! (Check[Int32.Parse(value)-1]==null) )
            {
                Console.WriteLine("Invaild Number");
                return false;
            }

            int i, j;
            for ( i = 0; i < 3; i++)    
                for ( j = 0; j < 3; j++) 
                    if (value == NewBoard[i, j])
                    {
                        NewBoard[i, j] = sign;
                        Check[Int32.Parse(value)-1] = sign;
                        break;
                    }
            return true;
        }
        public bool WinOrNot(string sign,int playerTurn)
        {
            //Rows
            if (Check[0] == sign && Check[1] == sign && Check[2] == sign) return true;
            else if (Check[3] == sign && Check[4] == sign && Check[5] == sign) return true;
            else if (Check[6] == sign && Check[7] == sign && Check[8] == sign) return true;

            //Coloms
            else if (Check[0] == sign && Check[3] == sign && Check[6] == sign) return true;
            else if (Check[1] == sign && Check[4] == sign && Check[7] == sign) return true;
            else if (Check[2] == sign && Check[5] == sign && Check[8] == sign) return true;

            //Diagonal
            else if (Check[0] == sign && Check[4] == sign && Check[8] == sign) return true;
            else if (Check[2] == sign && Check[4] == sign && Check[6] == sign) return true;

            return false;   
        }
        public void ResetBoard()
        {
            NewBoard = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            Check = new string[9];
        }
    }
}

