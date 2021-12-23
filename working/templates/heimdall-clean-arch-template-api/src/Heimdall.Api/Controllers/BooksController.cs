using System.Net;
using AutoMapper;
using Heimdall.Api.Middlewares;
using Heimdall.Api.ViewModels;
using Heimdall.Api.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Heimdall.Api.Controllers
{
    /// <summary>
    /// Books endpoints
    /// </summary>
    [ApiController]
    [ApiVersion("2")]
    [ApiExplorerSettings(GroupName = "v2")]
    [ServiceFilter(typeof(ApiExceptionsMiddleware))]
    [Route("api/v{version:apiVersion}/books")]
    public class BooksController
    {
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper">Automapper instance</param>
        public BooksController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Insert new book
        /// </summary>
        /// <param name="request">Book object</param>
        /// <returns>Inserted Book</returns>
        [HttpPost(Name = "CreatePrinter")]
        [SwaggerOperation(
            Summary = "Insert new book",
            Description = "Insert new book in database",
            OperationId = "InsertBook",
            Tags = new[] { "books" })]
        [SwaggerResponse((int)HttpStatusCode.Created, "Book created", typeof(SuccessResponseViewModel<BookViewModelResponse>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Wrong Information", typeof(ErrorResponseViewModel))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal Error", typeof(ErrorResponseViewModel))]
        public async Task<IActionResult> CreatePrinterAsync([FromBody] BookViewModelRequest request)
        {
            return new OkResult();
        }
    }
}