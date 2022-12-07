using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {// Outputs to the screen the options
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

            // conert.ToInt32 is a method used to convert a specific int value to its equivelent integer
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            // setting the result variable to 0
            int result = 0;
            //. switch statement is used instead of selection
            switch (action)
            {   //case is in place of selection. 
                // Value of the expression is compared with each value of the case
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                    // Program will runs this part of code if none of the cases above are matched.
                default:
                    Console.WriteLine("Wrong action!! try again");
                    // Will break out of the mean
                    break;
            }
            // will ouput the string plus the value that is stored in the result variable. 
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

        /*
         Public is the access specifier that allows it to be accessed publically. 
         */

        //Addition  function 
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  function
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Division function
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
    }
}
