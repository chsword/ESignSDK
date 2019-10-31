using System.Threading.Tasks;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E7%AD%BE%E7%BD%B2%E6%96%B9%E4%BF%A1%E6%81%AFAPI/%E4%B8%AA%E4%BA%BA%E8%B4%A6%E5%8F%B7%E5%88%9B%E5%BB%BA.html
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<AccountCreateByThirePartyUserIdResponse>> AccountCreateByThirdPartyUserId()
        {
            return new ApiResult<AccountCreateByThirePartyUserIdResponse>();
        }
    }
}