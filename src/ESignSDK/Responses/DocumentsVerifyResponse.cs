using System.Collections.Generic;
using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class DocumentsVerifyResponse
    {
        public List<DocumentsVerifySignInfoModel> SignInfos { get; set; }
        public class DocumentsVerifySignInfoModel
        {
            public string SealData { get; set; }

            public CertModel Cert { get; set; }
            public DocumentsVerifySignature Signature { get; set; }
        }

        public class DocumentsVerifySignature
        {
            /// <summary>
            /// 是否篡改
            /// </summary>

            public bool Modify { get; set; }

            /// <summary>
            /// 签署时间来源
            /// </summary>
            public string TimeFrom { get; set; }

            /// <summary>
            /// 签署时间
            /// </summary>
            public string SignDate { get; set; }


        }
    }
}