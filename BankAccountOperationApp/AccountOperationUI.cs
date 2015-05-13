using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }

        Account aAccount = new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            if (aAccount.AccountNumber != null || aAccount.CustomerName != null)
            {
                aAccount.AccountNumber = accountNumberTextBox.Text;
                aAccount.CustomerName = customerNameTextBox.Text;

                MessageBox.Show("Account created Successfulluy");

                accountNumberTextBox.Clear();
                customerNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Create Account");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);

            string message = aAccount.DepositeMoney(amount);

            MessageBox.Show(message);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);

            string message = aAccount.WithdrawMoney(amount);

            MessageBox.Show(message);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aAccount.Report());
        }
    }
}
