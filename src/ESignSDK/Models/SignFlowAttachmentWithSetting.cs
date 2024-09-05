using System.Collections.Generic;
using Newtonsoft.Json;

namespace ESignSDK.Models
{
    public class SignFlowAttachmentWithSetting
    {
        /// <summary>
        /// 附件名称	
        /// </summary>
        public string AttachmentName { get; set; }

        /// <summary>
        /// 附件Id	
        /// </summary>
        public string FileId { get; set; }
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionData { get; set; }
    }
}