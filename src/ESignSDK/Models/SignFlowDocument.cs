using System.Collections.Generic;
using Newtonsoft.Json;

namespace ESignSDK.Models
{
    public class SignFlowDocument
    {
        /// <summary>
        /// 文档id
        /// </summary>
        [Required]
        public string FileId { get; set; }

        /// <summary>
        /// 文档名称,默认文件名称	
        /// </summary>
        public string FileName { get; set; }

        public string FileUrl { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> ExtensionData { get; set; }
    }
}