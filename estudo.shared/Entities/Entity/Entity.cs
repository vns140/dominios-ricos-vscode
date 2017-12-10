using System;
using System.Collections.Generic;
using estudo.shared.Validation;

namespace estudo.shared.Entities
{
 
    public class Entity : Validator
    {        
        public Entity(Guid id)
        {
            Id = id;
            
        }

        public Guid Id { get;}
        
    }
}