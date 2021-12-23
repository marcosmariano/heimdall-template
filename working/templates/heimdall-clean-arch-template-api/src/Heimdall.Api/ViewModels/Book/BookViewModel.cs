namespace Heimdall.Api.ViewModels.Book
{
    /// <summary>
    /// ViewModel to receive a request
    /// </summary>
    public class BookViewModelRequest
    {
        string Name { get; set; }
        string Description { get; set; }
        double Value { get; set; }
    }

    /// <summary>
    /// ViewModel to return when a request was called
    /// </summary>
    public class BookViewModelResponse
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}