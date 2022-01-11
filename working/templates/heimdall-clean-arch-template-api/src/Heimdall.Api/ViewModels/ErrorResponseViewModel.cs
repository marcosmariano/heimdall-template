using System.Collections.Generic;

namespace Heimdall.Api.ViewModels
{
    public class ErrorResponseViewModel : BaseResponseViewModel
    {
        public List<ErrorViewModel>? Errors { get; set; }
    }
}