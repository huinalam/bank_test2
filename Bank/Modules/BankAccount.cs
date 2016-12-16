using System;

namespace Bank.Modules
{
    public class BankAccount
    {
        public BankAccount(int amount)
        {
            Balance = amount;
        }

        /// <summary>
        /// 잔고
        /// </summary>
        public int Balance { get; private set; }

        /// <summary>
        /// 출금
        /// </summary>
        /// <param name="money">금액</param>
        public void Withdraw(int amount)
        {
            if (Balance < amount)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            Balance -= amount;
        }

        /// <summary>
        /// 입금
        /// </summary>
        /// <param name="amount">입금 금액</param>
        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}
