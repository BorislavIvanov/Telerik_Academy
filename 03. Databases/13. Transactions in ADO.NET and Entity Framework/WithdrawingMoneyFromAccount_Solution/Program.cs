using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WithdrawingMoneyFromAccount_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardNumber = default(string);
            string pinNumber = default(string);
            decimal amountOfMoney = default(decimal);

            bool transactionContinue = true;

            GetWithdrawInformationFromConsole(ref cardNumber, ref pinNumber, ref amountOfMoney, ref transactionContinue);

            MakeWithdrawTransaction(cardNumber, pinNumber, amountOfMoney, transactionContinue);
        }

        private static void MakeWithdrawTransaction(string cardNumber, string pinNumber, decimal amountOfMoney, bool transactionContinue)
        {
            if (transactionContinue)
            {
                ATMEntities db = new ATMEntities();

                using (db)
                {
                    using (TransactionScope withdrawTransaction = new TransactionScope())
                    {
                        var bankAccount =
                            (from a in db.CardAccounts
                             where a.CardNumber == cardNumber && a.CardPIN == pinNumber
                             select a).First();

                        if (bankAccount == null)
                        {
                            Console.WriteLine("Wrong Account Data!!!");
                        }
                        else if (bankAccount.CardCash < amountOfMoney)
                        {
                            Console.WriteLine("Insufficient amount of money!!!");
                        }
                        else
                        {
                            bankAccount.CardCash -= amountOfMoney;
                            db.SaveChanges();

                            AddTransactionRecord(cardNumber, amountOfMoney, db);

                            withdrawTransaction.Complete();

                            Console.WriteLine("Transaction successful!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Transaction failure!!!");
            }
        }

        private static void GetWithdrawInformationFromConsole(
            ref string cardNumber, ref string pinNumber, ref decimal amountOfMoney, ref bool transactionContinue)
        {
            do
            {
                Console.Write("Enter the Card Number: ");
                cardNumber = Console.ReadLine();
            } while (cardNumber.Length != 10);


            do
            {
                Console.Write("Enter the Pin Number: ");
                pinNumber = Console.ReadLine();
            } while (pinNumber.Length != 4);

            string inputAmountOfMoney = default(string);

            do
            {
                Console.Write("Enter the Amount of Money: ");
                inputAmountOfMoney = Console.ReadLine();

                try
                {
                    amountOfMoney = decimal.Parse(inputAmountOfMoney);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect value for Amount of Money!!!");
                    transactionContinue = false;
                }
            } while (amountOfMoney <= 0);
        }

        private static void AddTransactionRecord(string cardNumber, decimal amountOfMoney, ATMEntities db)
        {
            using (TransactionScope recordTransacion = new TransactionScope())
            {
                var newTransactionRecord = new TransactionsHistory()
                {
                    CardNumber = cardNumber,
                    TransactionDate = DateTime.Now,
                    Ammount = amountOfMoney
                };

                db.TransactionsHistories.Add(newTransactionRecord);
                db.SaveChanges();

                recordTransacion.Complete();
            }
        }
    }
}
