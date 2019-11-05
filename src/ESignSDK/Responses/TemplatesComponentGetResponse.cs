using System.Collections.Generic;
using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class TemplatesComponentGetResponse
    {
        public long CreateTime { get; set; }
        public string DownloadUrl { get; set; }
        public int FileSize { get; set; }
        public List<StructComponent> StructComponents { get; set; }
        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public int TemplateType { get; set; }
        public long UpdateTime { get; set; }
    }
}