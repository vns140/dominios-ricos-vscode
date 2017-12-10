using System;
using estudo.domain.ValueObjects;

namespace estudo.domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime date, DateTime expireDate, decimal total, DateTime totalPaid, string owner, Document document, Address address, Email email) : base(date, expireDate, total, totalPaid, owner, document, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; }
        public string BoletoNumber { get; }
    }
}