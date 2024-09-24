using System.Runtime;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game 21, your goal is to get a number as close to 21 as possible without going over.");
           
            Random rand = new Random();
            int randomnumber = rand.Next(1, 7);

            Console.WriteLine("Are you Ready?");
            string answer = Console.ReadLine();
            
            if (answer != "no")
          
            {
                int sum = 0; 
               
                while (answer != "stop")           
                {
                    Console.WriteLine("Do you want to roll or stop");
                    answer = Console.ReadLine();
                   
                    if (answer != "roll")
                    { Console.WriteLine("You got " + sum + " total."); break; }
                   
                    randomnumber = rand.Next(1, 7);
                    sum += randomnumber;
                   
                    Console.WriteLine("You rolled " + randomnumber + ", Your total is " + sum + ".");
                   
                    if (sum > 21)
                    { Console.WriteLine("You got more than 21 points."); break; }
                }
                int sum1 = 0;
                while (sum1 < 17)
                {
                    randomnumber = rand.Next(1, 7);
                    sum1 += randomnumber; 
                   
                    Console.WriteLine("The dealer rolled " + randomnumber + ", they have " + sum1 + " total.");
                   
                    if (sum1 > 21)
                    { Console.WriteLine("The dealer got more than 21 points."); break; }
                }
               
                if (sum1 + sum > 42) 
                { Console.WriteLine("You both got more than 21 points, the dealer won."); }

                if (sum > 21)
                { Console.WriteLine("You got more than 21 points, you lost."); }
                
                if (sum1 > 21)
                { Console.WriteLine("The dealer got more than 21 points, you won."); }

                else
                {
                    if (sum1 > sum) { Console.WriteLine("The dealer got more points than you, you lost."); }
                    if (sum1 < sum) { Console.WriteLine("You got more point than the dealer, you won."); }
                }
           
            
            
            }


        }
    }
}
