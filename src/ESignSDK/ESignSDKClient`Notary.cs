using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 对接方可通过查询签署文件上链信息接口获取的docHash和antTxHash进行核验上链的信息是否一致，数据是否被篡改。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ApiResult<CheckAntfinNotaryResponse>> CheckAntfinNotary(
            CheckAntfinNotaryRequest request)
        {
            var result = await Http.PostAsync<
                CheckAntfinNotaryResponse,
                CheckAntfinNotaryRequest>(
                $"{Option.BaseUrl}/v1/checkAntfinNotary", request
            );
            return result;
        }

        /// <summary>
        /// 流程归档后，e签宝服务端会将签署后的文件哈希推送上链，对接方可通过流程flowId查询签署文件上链信息。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ApiResult<QuerySignAntPushInfoResponse>> QuerySignAntPushInfo(
            QuerySignAntPushInfoRequest request)
        {
            var result = await Http.PostAsync<
                QuerySignAntPushInfoResponse,
                QuerySignAntPushInfoRequest>(
                $"{Option.BaseUrl}/v1/checkAntfinNotary", request
            );
            return result;
        }
    }
}