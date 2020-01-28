using System;

namespace Interfaces
{
    internal class MyAccount : IAccount
    {
        private double _mBalance;

        public double GetBalance() => _mBalance;

        void IAccount.Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            _mBalance += amount;
        }

        void IAccount.Withdraw(double amount)
        {
            _mBalance = _mBalance - amount;
            if (_mBalance < 0) _mBalance -= 20;
        }
    }
}