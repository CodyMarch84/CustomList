using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Addition
    {
        public int addTwoNumbers(int firstValue, int secondValue)
        {
            displayFormula(firstValue, secondValue);
            int result = firstValue + secondValue;
            return result;
        }

        public void displayFormula(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + " + " + numberTwo);
        }

        public int GetUserInput()
        {
            int result;
            string response = Console.ReadLine();

            try
            {
                result = Int32.Parse(response);
            }
            catch
            {
                Console.WriteLine("Oops, you suck, invalid entry, try again!"); // need a number, 1-10
                return GetUserInput();
            }

            // BELOW - alternative example of validation of user input

            // bool isNumber = Int32.TryParse(response, out result);
            // while (!isNumber)
            // {
            //     Console.WriteLine("Oops, you suck, invalid entry, try again!");
            //     isNumber = Int32.TryParse(response, out result);
            // }

            return result;
        }
    }
}
    }
}
