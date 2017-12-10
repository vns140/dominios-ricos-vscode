using System;
using estudo.domain.ValueObjects;

namespace estudo.domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime date, DateTime expireDate, decimal total, DateTime totalPaid, string owner, Document document, Address address, Email email) : base(date, expireDate, total, totalPaid, owner, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; }
        public string CardNumber { get; }
        public string LastTransactionNumber { get; }
    }
}