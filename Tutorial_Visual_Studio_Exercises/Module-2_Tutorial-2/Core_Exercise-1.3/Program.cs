/* When a customer buys an item from a shop it is treated as a Transaction in the computer system. 
 * The Transaction object is created when total amount the customer is spending is calculated at the till
 * and this amount is stored in the Transaction object.
 * 
 * The Customer can pay for the Transaction in a number of ways via Credit Card with Cash
 * or via a Repayment Scheme. You can think of these as CashTransactions, CreditCardTransactions etc
 * 
 * If the Customer pays cash there is nothing extra to pay above the total Transaction cost
 * If the Customer pays by Credit card there is a 2% surcharge to pay
 * If the Customer pays by Repayment there is a surcharge of 10% but he only needs to pay 25% of the cost
 * when the purchases are made
 * 
 * You task is to model this requirement using OOP principles.
 * On the Console you will be able to create a Transaction of a given cost and then display what
 * type of Transaction it is based on the Customers wishes and what the cost to the Customer today is going
 * to be
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core_Exercise_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
