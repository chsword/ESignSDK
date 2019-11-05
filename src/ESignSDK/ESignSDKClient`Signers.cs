using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    /// <summary>
    /// 签署人相关操作
    /// </summary>
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 流程签署人催签
        /// </summary>
        public async Task<ApiResult<SignFlowExecuteUrlResponse>> SignFlowExecuteUrl(
            string flowId, string accountId, string organizeId = "",
            int urlType = 0)
        {
            var result = await Http.GetAsync<SignFlowExecuteUrlResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/executeUrl?accountId={accountId}&organizeId={organizeId}&urlType={urlType}"
            );
            return result;
        }

        /// <summary>
        /// 流程签署人催签
        /// </summary>
        public async Task<ApiResult<object>> SignFlowRushSign(string flowId, SignFlowRushSignRequest request)
        {
            var result = await Http.PutAsync<object, SignFlowRushSignRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signers/rushsign", request
            );
            return result;
        }
        /// <summary>
        /// 流程签署人列表
        /// </summary>
        public async Task<ApiResult<SignFlowSignersGetResponse>> SignFlowSignersGet(string flowId)
        {
            var result = await Http.GetAsync<SignFlowSignersGetResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signers"
            );
            return result;
        }
    }
}