namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0; //Private field for balance

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance to deposit.");
            }
        }


        public double GetBalance() //Method to retrieve balance
        {
            return balance;
        }

        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Welcome to the bank!");

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Check balance");
                Console.WriteLine("3. Leave the bank");
                Console.Write("Choose an option (1-3): ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            myAccount.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }

                        break;

                    case "2":
                        Console.WriteLine($"Balance: {myAccount.GetBalance()}");
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using the bank!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select 1, 2 or 3.");
                        break;


                }
            }
        }
    }
}    
    

