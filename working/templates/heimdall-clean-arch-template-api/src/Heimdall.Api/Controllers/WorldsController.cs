using System;
using System.Net;
using System.Threading.Tasks;
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
    [ServiceFilter(typeof(ApiExceptionsMiddleware))]
    [Route("api/v1/worlds")]
    public class WorldsController
    {
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper">Automapper instance</param>
        public WorldsController(IMapper mapper)
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
            Summary = "Insert new world",
            Description = "Insert new world for Bifrost",
            OperationId = "InsertWorld",
            Tags = new[] { "worlds" })]
        [SwaggerResponse((int)HttpStatusCode.Created, "World created", typeof(SuccessResponseViewModel<BookViewModelResponse>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Wrong Information", typeof(ErrorResponseViewModel))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal Error", typeof(ErrorResponseViewModel))]
        public async Task<IActionResult> CreateWorldAsync([FromBody] BookViewModelRequest request)
        {
            return new OkResult();
        }
    }
}