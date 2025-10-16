using System.ComponentModel.Design;

namespace casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            double balance;
            Die die1;
            Die die2;
            bool done = false;
            balance = 150;
            double bet;

            die1 = new Die();
            die2 = new Die();




            while (!done)
            {



                Console.WriteLine("hello welcome to my casino");

                Console.WriteLine("this is my dice rolling game and here is the rules");

                Console.WriteLine("1 Doubles Win  (2x)");

                Console.WriteLine("2 Not double Win 0.5x ");

                Console.WriteLine("3 Even Sum Win 1x ");

                Console.WriteLine("4 Odd Sum Win 1x");

                Console.WriteLine("Anything else incorrect Loses their");

                Console.WriteLine("Pick an option");

                choice = Console.ReadLine()?.ToLower().Trim() ?? "";
                Console.WriteLine();



                while (choice != "1" && choice != "2" && choice != "3" && choice != "q" && choice != "4")
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    choice = Console.ReadLine()?.ToLower().Trim() ?? "";
                    Console.WriteLine();
                }




                Console.WriteLine($"how much would u like to bet you have ${balance}");

                



                while (!double.TryParse(Console.ReadLine(), out bet))
                {
                    Console.WriteLine("Invalid input. Please enter a valid bet:");


                    
                    
                }






                die1.RollDie1();
                die1.Draw();
                Console.WriteLine(die1.Roll);

                die2.RollDie1();
                die2.Draw();


                Console.WriteLine(die2.Roll);

                Console.ReadLine();






                if (choice == "1")
                {



                    if (die1.Roll == die2.Roll)
                    {
                        balance = balance + bet * 2;
                        Console.WriteLine($"you won your new balnance is {balance}");
                        Console.WriteLine("click to bet agian");




                    }
                    else
                    {

                        balance = balance - bet;

                        Console.WriteLine($"you lost new balance is {balance}");
                        Console.WriteLine("click to bet agian");

                    }


                    Console.ReadLine();

                }


                if (choice == "2")
                {




                    if (die1.Roll != die2.Roll)
                    {
                        balance = balance + bet * 0.5;
                        Console.WriteLine($"you won your new balnance is {balance}");
                        Console.WriteLine("click to bet agian");
                        Console.ReadLine();




                    }
                    else
                    {

                        balance = balance - bet;

                        Console.WriteLine($"you lost new balance is {balance}");
                        Console.WriteLine("click to bet agian");
                        Console.ReadLine();

                    }

                }
                if (choice == "3")
                {

                    if ((die1.Roll + die2.Roll) == 2)
                    {
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }
                    else if ((die1.Roll + die2.Roll) == 4)
                    {
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }
                    else if ((die1.Roll + die2.Roll) == 6)
                    {
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }
                    else if ((die1.Roll + die2.Roll) == 8)
                    {
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }
                    else if ((die1.Roll + die2.Roll) == 10)
                    {
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }
                    else if ((die1.Roll + die2.Roll) == 12)
                    {

                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine("the sum was even you win");

                        balance = balance + bet;

                        Console.WriteLine($"new balance is {balance}");
                    }

                    else
                    {


                        balance = balance - bet;
                        Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                        Console.WriteLine($"you lost new balance is {balance}");
                        Console.WriteLine("click to bet agian");
                        Console.ReadLine();

                    }
                }

                    if (choice == "4")
                    {

                        if ((die1.Roll + die2.Roll) == 3)
                        {
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                            Console.WriteLine("the sum was odd you win");
                        Console.ReadLine();

                        balance = balance + bet;

                            Console.WriteLine($"new balance is {balance}");
                        Console.ReadLine();
                    }
                        else if ((die1.Roll + die2.Roll) == 5)
                        {
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                            Console.WriteLine("the sum was odd you win");

                            balance = balance + bet;

                            Console.WriteLine($"new balance is {balance}");
                        Console.ReadLine();
                    }
                        else if ((die1.Roll + die2.Roll) == 7)
                        {
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                            Console.WriteLine("the sum was odd you win");

                            balance = balance + bet;

                            Console.WriteLine($"new balance is {balance}");
                        Console.ReadLine();
                    }
                        else if ((die1.Roll + die2.Roll) == 9)
                        {
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                            Console.WriteLine("the sum was odd you win");

                            balance = balance + bet;

                            Console.WriteLine($"new balance is {balance}");
                        Console.ReadLine();
                    }
                        else if ((die1.Roll + die2.Roll) == 11)
                        {
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll}");
                            Console.WriteLine("the sum was odd you win");

                            balance = balance + bet;

                            Console.WriteLine($"new balance is {balance}");
                        Console.ReadLine();
                    }


                        else
                        {


                            balance = balance - bet;
                            Console.WriteLine($"the sum was {die1.Roll + die2.Roll} witch is even");
                            Console.WriteLine($"you lost new balance is {balance}");
                            Console.WriteLine("click to bet agian");
                            Console.ReadLine();

                        }





































                    }















               
            }
        }
    }
}
