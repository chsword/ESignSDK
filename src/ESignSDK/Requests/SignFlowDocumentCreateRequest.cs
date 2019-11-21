using ESignSDK.Models;

namespace ESignSDK.Requests
{
    public class SignFlowDocumentCreateRequest
    {
        /// <summary>
        /// 文档列表数据	
        /// </summary>
        public SignFlowDocumentWithSetting[] Docs { get; set; }
    }
}