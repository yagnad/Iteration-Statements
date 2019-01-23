using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gather the input from user
            Console.Write("Enter an Integer value between 1 and 20 to execute an iterative statement:");

            //Use the try catch block to validate user input
            try
            {
                string number = Console.ReadLine(); 
                //Get the data from user

                int number_value = int.Parse(number);
                //parse the str variable to int to use in the method logic

                //Execute a for loop for user input between 1 and 5
                if ((number_value > 0) && (number_value <= 5))
                {
                    Console.WriteLine("\nExecuting a For Loop!");
                    Console.WriteLine("\nThe For Loop will iterate " + number_value.ToString() + " times");

                    //Here is the for loop
                    for (int i = 0; i < number_value; i++)
                    {
                        Console.WriteLine("The value of the variable in this iteration is : " + i.ToString());
                    }

                    Console.WriteLine("\nPress any key to exit the program");
                    //Pause the program for user input
                    Console.ReadKey(true);
                    //Exits the program
                }//end of If statement

                else if ((number_value > 5) && (number_value <= 10))
                {
                    Console.WriteLine("\nExecuting a While Loop!");
                    Console.WriteLine("\nThe While Loop will iterate " + number_value.ToString() + " times");

                    //Here is the while loop
                    while (number_value> 0)
                    {
                        Console.WriteLine("The value of the variable in this iteration is : " + number_value.ToString());
                        number_value--;
                    }

                
                    Console.WriteLine("\nPress any key to exit the program");
                    //Pause the program for user input
                    Console.ReadKey(true);
                    //Exits the program

                }//end of else if statement
                else if ((number_value > 10) && (number_value <= 20))
                {
                    Console.WriteLine("\nExecuting a Do While Loop!");
                    Console.WriteLine("\nThe Do While Loop will iterate " + number_value.ToString() + " times");

                    //Here is the do while loop
                    do
                    {
                        Console.WriteLine("The value of the variable in this iteration is : " + number_value.ToString());
                        number_value--;
                    } while (number_value > 0);

                    Console.WriteLine("\nPress any key to exit the program");
                    //Pause the program for user input
                    Console.ReadKey(true);
                    //Exits the program
                    
                } //end of else if
                //If the user does not enter a value between 1 and 20, display an error message
                else
                {
                    Console.WriteLine("Pls enter a valid number between 1 to 20 and try it again");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                }//end of else statement


            }//End of try block

            catch
            {
                Console.WriteLine("Pls enter a valid number between 1 to 20 and try it again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);

            }//End of catch block
        }//End of Main
    }//End of class
}//End of namespace
