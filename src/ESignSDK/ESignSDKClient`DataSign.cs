using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 传入待签文本原文、文本签署后的签名结果，验证文本是否被篡改、加密数字证书信息。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ApiResult<DataSignVerifyResponse>> DataSignVerify(
            DataSignVerifyRequest request)
        {
            var result = await Http.PostAsync<
                DataSignVerifyResponse,
                DataSignVerifyRequest>(
                $"{Option.BaseUrl}/v1/dataSign/verify", request
            );
            return result;
        }

        /// <summary>
        /// 传入待签文本原文，使用指定账号的数字证书进行加密，如不指定账号id，则使用对接平台数字证书对文本进行加密。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ApiResult<DataSignResponse>> DataSign(
            DataSignRequest request)
        {
            var result = await Http.PostAsync<
                DataSignResponse,
                DataSignRequest>(
                $"{Option.BaseUrl}/v1/dataSign", request
            );
            return result;
        }
    }
}