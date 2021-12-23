namespace Heimdall.Domain
{
    /// <summary>
    /// Book Entity
    /// </summary>
    public class Book
    {
        Guid Id {get;set;}
        string Name {get;set;}
        string Description {get;set;}
        double Value {get;set;}
        DateTime CreatedAt {get;set;}
        DateTime UpdatedAt {get;set;}
    }
}