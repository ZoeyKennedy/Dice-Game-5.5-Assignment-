namespace Dice_Game__5._5_Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance;
            double bet;
            string type;
            double amountWon;

            balance = 100;
            

            Die die1, die2;

            die1 = new Die();
            die2 = new Die();

            
            Console.WriteLine("Bank balance: " + balance);
            Console.WriteLine("How much money would you like to bet on the dice game?");
            bet = Convert.ToDouble(Console.ReadLine());
            while (bet > balance) 
            {
                Console.WriteLine("Invalid bet. PLease enter an amount lower than your bank balance.");
                bet = Convert.ToDouble(Console.ReadLine());
                
            }
           
            Console.WriteLine("Would you like to bet on doubles, not doubles, an even sum or an odd sum? ");
            Console.WriteLine("Type the name of the type of bet");
            type = Console.ReadLine();
            type = type.ToUpper();

            
            switch (type)
            {
                case "DOUBLES" or "DOUBLE":
                    die1 =new Die();  
                    die2 =new Die();

                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    Console.WriteLine(die2);
                    die2.DrawRoll();

                    if (die1 == die2)
                    { 
                        amountWon = bet * 2 ;
                        balance = amountWon + bet;
                        Console.WriteLine("You won " + amountWon + "!");
                        balance = balance + amountWon;
                        Console.WriteLine("Your new balance is " + (balance));
                    }
                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("Sorry! You lost your bet.");
                        Console.WriteLine("Your new balance is " + (balance));
                        //bet again?
                    }
                    break;
                case "NOT DOUBLES" or "NOT DOUBLE":
                    die1 = new Die();
                    die2 = new Die();

                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    Console.WriteLine(die2);
                    die2.DrawRoll();

                    if (die1 != die2)
                    {
                        amountWon = bet /2;
                        balance = balance + amountWon;
                        Console.WriteLine("You won " + (amountWon) + "!");
                        Console.WriteLine("Your new balance is " + balance);

                    }
                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("Sorry! You lost your bet.");
                        Console.WriteLine("Your new balance is " + balance);
                        
                    }
                    break;
                case "EVEN SUM":
                    if 
                    {

                    }

                    break;
                case "ODD SUM":
                    Console.WriteLine();
                    break;
               
            }




        }
    }
}
