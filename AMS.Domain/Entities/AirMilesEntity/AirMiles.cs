using AMS.Domain.Entities.MovementEntity;

namespace AMS.Domain.Entities.AirMilesEntity
{
    public sealed class AirMiles : Movement
    {
        public AirMilesId Id { get; private set; }
        public Guid AirlineId { get; private set; }
    }
}
