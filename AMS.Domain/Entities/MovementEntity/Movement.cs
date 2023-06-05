using AMS.Domain.Enums;

namespace AMS.Domain.Entities.MovementEntity
{
    public abstract class Movement
    {
        public Movement MovementType { get; private set; }
        public DateTime Date { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public DateTime Expiration { get; private set; }
    }
}
