using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 添加平台自动盖章签署区
        /// 
        /// 接口描述 向指定流程中创建签署区，每个签署区视为一个任务，系统会自动按照流程流转。 签署区的添加必须在签署文档添加之后, 签署区信息内部包含签署文档信息（平台自动签无需指定签署人信息，默认签署人是对接的企业）。
        ///
        /// 签署区创建完成，流程开启后，系统将自动完成“对接平台自动盖章签署区”的盖章，对接平台可全程无感完成本次签署。
        /// </summary>
        public async Task<ApiResult<SignFlowFieldResponse>> SignFlowFieldAddPlatform(
            string flowId, SignFlowFieldAddPlatformRequest request)
        {
            var result = await Http.PostAsync<SignFlowFieldResponse, SignFlowFieldAddPlatformRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signfields/platformSign", request
            );
            return result;
        }

        /// <summary>
        /// 添加签署方自动盖章签署区
        /// </summary>
        public async Task<ApiResult<SignFlowFieldResponse>> SignFlowFieldAutoSign(
            string flowId, SignFlowFieldAutoSignRequest request)
        {
            var result = await Http.PostAsync<SignFlowFieldResponse, SignFlowFieldAutoSignRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signfields/autoSign", request
            );
            return result;
        }

        /// <summary>
        /// 删除签署区
        /// </summary>
        public async Task<ApiResult<SignFlowFieldDeleteResponse>> SignFlowFieldDelete(
            string flowId, string[] signfieldIds)
        {
            var result = await Http.DeleteAsync<SignFlowFieldDeleteResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signfields?signfieldIds={string.Join(",", signfieldIds)}"
            );
            return result;
        }

        /// <summary>
        /// 查询签署区列表
        /// </summary>
        public async Task<ApiResult<SignFlowFieldGetResponse>> SignFlowFieldGet(
            string flowId, string accountId = null, string[] signfieldIds = null)
        {
            var result = await Http.GetAsync<SignFlowFieldGetResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signfields"
            );
            return result;
        }

        /// <summary>
        /// 添加手动盖章签署区
        /// </summary>
        public async Task<ApiResult<SignFlowFieldResponse>> SignFlowFieldHandSign(
            string flowId, SignFlowFieldHandSignRequest request)
        {
            var result = await Http.PostAsync<SignFlowFieldResponse, SignFlowFieldHandSignRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/signfields/handSign", request
            );
            return result;
        }
    }
}