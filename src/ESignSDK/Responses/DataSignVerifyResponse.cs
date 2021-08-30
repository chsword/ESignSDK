using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class DataSignVerifyResponse
    {

        public SignInfoModel SignInfo { get; set; }

        public class SignInfoModel
        {
            public CertModel Cert { get; set; }
            public Signature Signature { get; set; }
        }

       

        public class Signature
        {
            /// <summary>
            /// 是否篡改
            /// </summary>
            public bool Modify { get; set; }
        }

    }
}