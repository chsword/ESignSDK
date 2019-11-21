using System.Collections.Generic;

namespace ESignSDK.Requests
{
    public class SignFlowFieldAutoSignRequest
    {
        public List<SignFieldAutoSign> Signfields { get; set; }
    }

    public class SignFieldAutoSign : SignField
    {
        /// <summary>
        /// 签约主体账号标识， 将使用该主体账号对应的数字证书完成本次签署，
        /// 如：当存在签署操作人代某机构签署时，需要传入该机构的账号id；	
        /// </summary>
        public string AuthorizedAccountId { get; set; }
    }
}