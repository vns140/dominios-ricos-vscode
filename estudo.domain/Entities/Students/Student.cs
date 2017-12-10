using System.Collections.Generic;
using System.Linq;
using estudo.domain.ValueObjects;

namespace estudo.domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; set; }
        public Document Document { get; }
        public Email Email { get; }

        public IReadOnlyCollection<Subscription> Subscriptions {get{ return _subscriptions.ToArray();}}

        public void AddSubscription(Subscription subscription)
        {
               foreach (var sub in Subscriptions)
               {
                   sub.Inactivate();
               } 

               _subscriptions.Add(subscription);
        }
    }
       
}