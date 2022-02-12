namespace Heimdall.Domain
{
    public class World : BaseEntity<Guid>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Size { get; set; }
    }
}