namespace InterfacesStuff
{
    internal interface IAccount
    {
        double getBalance();

        void deposit(double amount);

        void withdraw(double amount);
    }
}