using estudo.domain.ValueObjects.Validations;
using estudo.shared.ValueObjects;
using FluentValidation.Results;

namespace estudo.domain.ValueObjects
{
    public class Email : ValueObject
    {
        protected Email(){}
        
        private Email(string address)
        {
            Address = address;
        }

        public static Email Factory(string address)
        {
              Email email = new Email(address);
              EmailValidator  validator  = new EmailValidator();
              email.SetValidation(validator.Validate(email));  
              return email;                          
        }
        

        public string Address { get; }
    }
}