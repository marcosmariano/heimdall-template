namespace Heimdall.Api.ViewModels.Book
{
    public class BookViewModelRequest
    {
        string Name {get;set;}
        string Description {get;set;}
        double Value {get;set;}
    }

        public class BookViewModelResponse
    {
        Guid Id {get;set;}
        string Name {get;set;}
        string Description {get;set;}
    }
}