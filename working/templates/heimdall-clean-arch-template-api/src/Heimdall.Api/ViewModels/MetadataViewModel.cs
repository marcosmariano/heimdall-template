using System;

namespace Heimdall.Api.ViewModels
{
    public class MetadataViewModel
    {
        public string Server => Environment.MachineName;
        public uint Limit { get; set; }
        public uint Offset { get; set; }
        public uint RecordCount { get; set; }
    }
}