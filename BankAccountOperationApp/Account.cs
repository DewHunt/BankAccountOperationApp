using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperationApp
{
    class Account
    {
        public string AccountNumber;
        public string CustomerName;
        public double Balance;

        
        public string WithdrawMoney(double amount)
        {
            if (AccountNumber != null || CustomerName != null)
            {
                if (amount > 0)
                {
                    if (Balance > amount)
                    {
                        Balance -= amount;
                        return "Successfull";
                    }
                    else
                    {
                        return "Insufficient Balance";
                    }
                }
                else
                {
                    return "Enter Valid Amount";
                }
            }
            else
            {
                return "Please Create Account";
            }
        }

        public string DepositeMoney(double amount)
        {
            if (AccountNumber != null || CustomerName != null)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    return "Successfull";
                }
                else
                {
                    return "Enter Valid Amount";
                }
            }
            else
            {
                return "Please Create Account";
            }
        }

        public string Report()
        {
            return CustomerName + ", Your Balance is : " + Balance;
        }
    }
}
