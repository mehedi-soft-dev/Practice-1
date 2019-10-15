using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperation
{
    public partial class AccountUI : Form
    {
        Account account = new Account();

        public AccountUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            account.AccountNumber = accountNumberTextBox.Text;
            account.CustomerName = customerNameTextBox.Text;

            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            account.Deposit(Convert.ToDouble(ammountTextBox.Text));

            ammountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double ammount = Convert.ToDouble(ammountTextBox.Text);
            if (account.Balance >= ammount)
            {
                account.Withdraw(ammount);

                ammountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Insufficient Balance..!");
                return;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string message = account.CustomerName + ", Your Account Number : " + account.AccountNumber + ", Balance : " + account.Balance + "Tk.";
            MessageBox.Show(message);
        }
    }
}
