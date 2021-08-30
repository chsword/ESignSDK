using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 如果针对本地保存的签署文件进行验签，则通过“上传方式创建文档”接口上传文件，获取fileid，再传入文件id，进行验签；
        /// 如果是针对某一签署流程对应的某一签署后的文件进行验签，则可直接传入签署流程id+文件id，
        /// 直接进行验签。
        /// </summary>
        public async Task<ApiResult<DocumentsVerifyResponse>> DocumentsVerify(string fileId, string flowId = null)
        {
            var result = await Http.GetAsync<DocumentsVerifyResponse>(
                $"{Option.BaseUrl}/v1/documents/{fileId}/verify" + (string.IsNullOrWhiteSpace(flowId) ? "" : $"?flowId={flowId}")
            );
            return result;
        }

    }
}