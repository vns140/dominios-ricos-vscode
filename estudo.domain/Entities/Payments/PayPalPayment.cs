using System;
using estudo.domain.ValueObjects;

namespace estudo.domain.Entities
{
    public class PayPalCardPayment : Payment
    {
        public PayPalCardPayment(string lastTransactionCode, DateTime date, DateTime expireDate, decimal total, DateTime totalPaid, string owner, Document document, Address address, Email email) : base(date, expireDate, total, totalPaid, owner, document, address, email)
        {
            LastTransactionCode = lastTransactionCode;
        }

        public string LastTransactionCode { get;}
    }
}