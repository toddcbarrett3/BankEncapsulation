using System.ComponentModel.Design;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            var exit = true;
            do
            {
                Console.WriteLine("Welcome:");
                Console.WriteLine("To check balance: Press 1");
                Console.WriteLine("To deposit money: Press 2");
                Console.WriteLine("To withdraw money: Press 3");
                Console.WriteLine("To exit the system: Press 4");
                var userSelection = int.Parse(Console.ReadLine());
 
                if (userSelection == 4)
                {
                    Console.WriteLine("Thank you for your business!");
                    exit = false;
                    break;
                }
                else
                {
                    switch (userSelection)
                    {
                        case 1:
                            account.GetBalance();
                            break;
                        case 2:
                            Console.WriteLine($"How much do you want to deposit?");
                            var userInputDeposit = double.Parse(Console.ReadLine());
                            account.Deposit(userInputDeposit);
                            break;
                        case 3:
                            Console.WriteLine($"How much do you want to withdraw?");
                            var userInputWithdraw = double.Parse(Console.ReadLine());
                            account.Withdraw(userInputWithdraw);
                            break;
                        default:
                            Console.WriteLine("please enter a valid selection");
                            break;
                    }
                }
            } while (exit == true);
        }
    }
}
