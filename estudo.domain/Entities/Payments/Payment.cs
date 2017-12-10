using System;
using estudo.domain.ValueObjects;

namespace estudo.domain.Entities
{
    public abstract class Payment
    {
        public Payment(DateTime date, DateTime expireDate, decimal total, DateTime totalPaid, string owner, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            Date = date;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; }
        public DateTime Date { get;}
        public DateTime ExpireDate { get; }
        public decimal Total { get;}
        public DateTime TotalPaid { get; }
        public string Owner { get;}
        public Document  Document { get;}        
        public Address Address { get;}
        public Email Email { get;}

    }

    

  

  
}