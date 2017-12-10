using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace estudo.shared.Validation
{
    
    public abstract class Validator
    {
        public Validator() => IsValid = true;

        private IList<ValidationFailure> _errors = null;
        public IReadOnlyCollection<ValidationFailure> Errors {get{ return _errors.ToArray();}}
        
        public virtual bool IsValid { get; private set; }
        
        public void SetValidation(ValidationResult result)
         {
                if(!result.IsValid)
                {
                    IsValid = false;

                    _errors.ToList().AddRange(result.Errors);
                }
         }
        
    }
}