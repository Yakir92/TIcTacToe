using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Input {

        private string newInput;

        public Input (string newInput)
        {
            this.newInput = newInput;
        }
        public Input()
        {
            Console.WriteLine("New Input Created");
        }
        public string NewInput {
            get 
            {
                return newInput;
            }
            set 
            {
                try {
                    while (!(CheckInput(value)))
                        newInput = Console.ReadLine();
                    this.newInput = value;
                }
                catch (ArgumentNullException) {
                    Console.WriteLine("Enter A Vaild Digit");
                } 
            }
        }
        public bool CheckInput(string input)
        {
            try
            {
                if (!(input.All(char.IsDigit)) && (Int32.Parse(input) >= 1 || Int32.Parse(input) <= 9))
                {
                    Console.WriteLine("Not A Number Or Number Out Of Range. Re-Enter Number");
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
