using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 关闭静默签署
        /// </summary>
        public async Task<ApiResult<bool>> SignAuthOff(string accountId)
        {
            var result = await HttpUtils.DeleteAsync<bool>(
                $"{Option.BaseUrl}/v1/signAuth/{accountId}"
            );
            return result;
        }

        /// <summary>
        /// 开户静默签署
        /// </summary>
        public async Task<ApiResult<bool>> SignAuthOn(string accountId, SignAuthOnRequest request = null)
        {
            var result = await HttpUtils.PostAsync<
                bool,
                SignAuthOnRequest>(
                $"{Option.BaseUrl}/v1/signAuth/{accountId}",
                request ?? new SignAuthOnRequest()
            );
            return result;
        }
    }
}