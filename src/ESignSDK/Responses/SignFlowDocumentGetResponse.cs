using System.Collections.Generic;
using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class SignFlowDocumentGetResponse
    {
        public List<SignFlowDocument> Docs { get; set; }
    }
}