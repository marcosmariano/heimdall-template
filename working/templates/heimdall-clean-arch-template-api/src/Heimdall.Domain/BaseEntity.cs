namespace Heimdall.Domain
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}