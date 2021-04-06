using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        private int PlayerTurn = 1;
        private string PlayerSign = "X";

        public int playerTurn { get { return PlayerTurn; } set { this.PlayerTurn = value; } }
        public string playerSign { get { return PlayerSign; } set { this.PlayerSign = value; } }
        public Player()
        {
            Console.WriteLine("Player Has Been Created");
        }
        public void TurnChange()
        {
            if (playerTurn == 1) { playerTurn = 2; playerSign = "O"; }
            else if (playerTurn == 2) { playerTurn = 1; playerSign = "X";}    
        }

    }
}
