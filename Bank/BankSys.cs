using System.Globalization;

namespace Bank {
    internal class BankSys {

        private double _withdrawTax = 5.00;
        public double Fund { get; set; }
        internal int AccountNumber { get; private set; }
        internal string _accountName { get; private set; }
        internal string InitialDeposity { private get; set; }
        internal double InitialDeposityValue { private get; set; }
        internal double DepositValue { get; set; }
        internal double _withdrawValue { get; set; }



        public BankSys(int accountNumber, string accountName, string initialDeposity) {
            AccountNumber = accountNumber;
            _accountName = accountName;
            InitialDeposity = initialDeposity;
        }

        public BankSys(int accountNumber, string accountName, string initialDeposity, double initialDeposityValue) : this(accountNumber, accountName, initialDeposity) {
            if (initialDeposityValue != 0) {
                InitialDeposityValue = initialDeposityValue;
            }
        }

        public void IntroAccount() {
            Console.WriteLine($"Dados da conta \n Conta: {AccountNumber}, Titular: {_accountName}, Saldo: {InitialDeposityValue.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Deposit() {
            Console.WriteLine("Entre o valor do deposito:");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Fund += depositValue + InitialDeposityValue;
            Console.WriteLine($"Dados da conta atualizados: \n Conta {AccountNumber}, Titular: {_accountName}, Saldo: {Fund.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Withdraw() {
            Console.WriteLine("Entre o valor para saque:");
            double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Fund = Fund - withdrawValue - _withdrawTax;
            Console.WriteLine($"Dados da conta atualizados: \n Conta {AccountNumber}, Titular: {_accountName}, Saldo: {Fund.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

