using AMS.Domain.Entities.MovementEntity;

namespace AMS.Domain.Entities.PointsEntity
{
    public sealed class Points : Movement
    {
        public PointsId Id { get; private set; }
        public Guid CreditCardId { get; private set; }
    }
}
