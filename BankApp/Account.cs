using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    enum TypeOfAccount
    {
        Checking,
        Saving,
        Cd,
        Loan
    }
    /// <summary>
    /// This is about bank account
    /// </summary>
    class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        #endregion

        #region
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Properties
        public int AccountNumber { get; private set; }
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;

        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion


    }
}

