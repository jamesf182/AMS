namespace AMS.Domain.Entities.AirlineEntity
{
    public class Airline
    {
        public AirlineId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public bool Active { get; private set; }
    }
}
