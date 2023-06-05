namespace AMS.Domain.Entities.CreditCardBrandEntity
{
    public class CreditCardBrand
    {
        public CreditCardBrandId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public bool Active { get; private set; }
    }
}
