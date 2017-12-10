using estudo.shared.ValueObjects;

namespace estudo.domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neignborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neignborhood = neignborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public string Street { get;}
        public string Number { get; }
        public string Neignborhood { get;}
        public string City { get;}
        public string State { get;}
        public string Country { get;}
        public string ZipCode { get;}


    }
}