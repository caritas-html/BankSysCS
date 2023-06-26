using System.Globalization;

namespace Bank // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bem-vindo ao banco Radical");
            Console.WriteLine("digite o número da conta:");
            int AccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o seu nome:");
            string AccountName = Console.ReadLine();
            Console.WriteLine("haverá deposito inicial (s/n):", CultureInfo.InvariantCulture);
            string InitialDeposit = Console.ReadLine();

            if (InitialDeposit.Equals("n")) {
                BankSys bankSys = new(AccountNumber, AccountName, InitialDeposit);
                bankSys.IntroAccount();
                bankSys.Deposit();
                bankSys.Withdraw();
            }
            else if (InitialDeposit.Equals("s")) {
                Console.WriteLine("Entre o valor do deposito inicial:");
                double InitialDepositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                BankSys bankSys = new(AccountNumber, AccountName, InitialDeposit, InitialDepositValue);
                bankSys.IntroAccount();
                bankSys.Deposit();
                bankSys.Withdraw();
            }
            else { 
                Console.WriteLine("Houve um erro, reinicie o programa");
            }

        }
    }
}
