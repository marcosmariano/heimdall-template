using System.Net;
using Cabother.Exceptions;
using Cabother.Exceptions.Databases;
using Cabother.Exceptions.Requests;
using FluentValidation;
using Heimdall.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Heimdall.Api.Middlewares
{
    public class ApiExceptionsMiddleware : ExceptionFilterAttribute
    {
        private readonly IWebHostEnvironment _env;

        public ApiExceptionsMiddleware(IWebHostEnvironment env)
        {
            _env = env;
        }

        public override void OnException(ExceptionContext context)
        {
            var problem = new ErrorViewModel
            {
                Status = 500,
                UserMessage = context.Exception.Message,
                Detail = _env.IsDevelopment() ? context.Exception.ToString() : "",
                Type = context.Exception.GetType().Name,
                ErrorCode = context.Exception is BaseException baseException ? baseException.ErrorCode : ""
            };

            var responseError = new ErrorResponseViewModel
            {
                Errors = new List<ErrorViewModel> { problem }
            };

            switch (context.Exception)
            {
                case ConflictException:
                    problem.Status = (int)HttpStatusCode.Conflict;
                    context.Result = new ConflictObjectResult(responseError);
                    return;

                case EntityNotFoundException:
                    problem.Status = (int)HttpStatusCode.NotFound;
                    context.Result = new NotFoundObjectResult(responseError);
                    return;

                case BadRequestException:
                    problem.Status = (int)HttpStatusCode.BadRequest;
                    context.Result = new BadRequestObjectResult(responseError);
                    return;

                case ValidationException validationEx:
                    problem.Status = (int)HttpStatusCode.BadRequest;
                    problem.UserMessage = validationEx.Errors.First().ErrorMessage;
                    context.Result = new BadRequestObjectResult(responseError);
                    return;

                default:
                    var result = new ObjectResult(responseError);
                    result.StatusCode = problem.Status;
                    context.Result = result;
                    return;
            }
        }
    }
}