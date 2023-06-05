namespace AMS.Domain.Entities.CreditCardEntity
{
    public class CreditCard
    {
        public CreditCardId Id { get; private set; }
        public Guid CreditCardBrandId { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int LastDigits { get; private set; }
        public bool Active { get; private set; }
    }
}
