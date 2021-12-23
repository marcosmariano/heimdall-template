using System.Collections.Generic;

namespace Heimdall.Api.ViewModels
{
    public class SuccessResponseViewModel<T> : BaseResponseViewModel
        where T : class
    {
        public SuccessResponseViewModel()
        {
        }

        public SuccessResponseViewModel(List<T> items)
        {
            Records = items;
            Meta.Limit = 50;
            Meta.Offset = 0;
            Meta.RecordCount = (uint)Records.Count;
        }

        public SuccessResponseViewModel(T item)
            : this(new List<T> {item})
        {
        }

        public List<T> Records { get; set; }
    }
}