/*Austin Stephens
 10/22/2022

 * -----------------------------------------------------------------------
#
##
## Purpose of code:

Write a program that is a calculator. The program should take input from the users as two integers. 
The user will then be provided a menu to select which operation to be performed:

Add
Subtract
Multiply
Divide
-------------------------------------------------------------Your program must have the following:

t should then output the numbers, the operator, and the result.

For the input of the menu - please ensure the user only inputs a 1, 2, 3, or 4 - all other inputs should display a notice and ask them to try again.
Ensure that your program handles exceptions such as division by zero.


Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Decision statement - that determines what the user entered and will give the price of the ticket.
Proper mathematical calculations
Proper output - so user can see their answer.
You are required to use a loop for input validation.
You need to have a try/catch.
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs

*/
using System;


namespace Calculator
{
    class NumClass
    {

        public string? Operator { get; set; }
        public int? FirstNum { get; set; }
        public int? SecondNum { get; set; }
        public int? Sum { get; set; }
    }





    class RunHere
    {
        static void Main(string[] args)
        {
            String StringPass = "";
            string UserIN = "";
            NumClass FirstNum1 = new NumClass();

            do
            {

                //---------------------------1
               
                Menu();
                Console.WriteLine("Please Enter First INT: | Exit to exit.");
                UserIN = Console.ReadLine();
                if (CheckExit(UserIN) == true)
                {
                    break;
                }
                FirstNum1.FirstNum = Convert.ToInt32(UserIN);
               

                //---------------------------2
                Menu();
                Console.WriteLine("Please Enter Operator: | Exit to exit.");
                UserIN = Console.ReadLine();
                if (CheckExit(UserIN) == true)
                {

                    break;
                }


                //cheakOperator
                StringPass = UserIN;
                while (CheakOperator(UserIN) == false)
                {

                    Console.WriteLine("Error:");
                    Console.WriteLine("Please Enter a Correct Operator ( *, -, +, / ) ");
                    UserIN = Console.ReadLine();
                    StringPass = UserIN;
                }







                //---------------------------3 
                Menu();
                Console.WriteLine("Please Enter Second Int: | Exit to exit.");
                UserIN = Console.ReadLine();
                if (CheckExit(UserIN) == true)
                {
                    break;
                }
                FirstNum1.SecondNum = Convert.ToInt32(UserIN);



                
                switch (StringPass)
                {
                    case "+":
                        FirstNum1.Sum = FirstNum1.FirstNum + FirstNum1.SecondNum;
                        break;
                    case "-":
                        FirstNum1.Sum = FirstNum1.FirstNum - FirstNum1.SecondNum;
                        break;
                    case "*":
                        FirstNum1.Sum = FirstNum1.FirstNum * FirstNum1.SecondNum;
                        break;
                    case "/":
                        //catching after zero has been brought in
                        try
                        {
                            FirstNum1.Sum = (FirstNum1.FirstNum / FirstNum1.SecondNum);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Tried diving by zero");
                        }
                        finally
                        {
                            FirstNum1.Sum = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("Error: Please Enter Valid Operator: ");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
                Console.WriteLine("Your Sum Is: " + FirstNum1.Sum);
                Console.WriteLine("*Enter To Continue | Exit to exit");
                UserIN = Console.ReadLine();

            } while (CheckExit(UserIN) == false);


            //func
            static void Menu()
            {
                Console.Clear();
                Console.WriteLine("*** Menu ***");
                Console.WriteLine("||||||||||||");
            }

            //If True User Wants to Exit
            static bool CheckExit(string IN)
            {
                if (IN == "Exit")
                {
                    return true;
                }
                else if (IN == "exit")
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }

            static bool CheakOperator(string IN)
            {
                if (IN == "+" || IN == "-" || IN == "/" || IN == "*")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


    }

}


