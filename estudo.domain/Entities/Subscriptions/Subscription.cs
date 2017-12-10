using System;
using System.Collections.Generic;
using System.Linq;

namespace estudo.domain.Entities
{
    public class Subscription
    {

        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate, List<Payment> payments)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = false;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; }
        public DateTime LastUpdateDate { get; private set;}
        public DateTime? ExpireDate { get; }
        public bool Active { get; private set;}
        public IReadOnlyCollection<Payment> Payments { get{return _payments.ToArray();} }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Inactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}