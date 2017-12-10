using estudo.domain.ValueObjects.Enums;
using estudo.shared.ValueObjects;

namespace estudo.domain.ValueObjects
{
    public class Document: ValueObject
    {
        public Document(string number,EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; }

        public EDocumentType Type { get; }
    }
}