using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    private class BankAccount
    public void Deposit(double depositAmount)
    {
        balance += depositAmount;
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
    }
}
