namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much do you want to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            
            Console.WriteLine($"Thank you! Your current account balance is now {account.GetBalance()}");


        }
    }
}
