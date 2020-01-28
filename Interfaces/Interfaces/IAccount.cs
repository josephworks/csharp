namespace Interfaces
{
    internal interface IAccount
    {
        double GetBalance();

        void Deposit(double amount);

        void Withdraw(double amount);
    }
}