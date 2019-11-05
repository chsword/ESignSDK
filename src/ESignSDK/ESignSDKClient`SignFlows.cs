using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    /// <summary>
    /// 签署流程
    /// </summary>
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 签署流程归档
        /// 接口描述 手动归档签署流程，归档后所有资源均不可修改。归档前签署流程中的所有签署人必须都签署完成。如创建流程时设置了自动归档，则无需调用本接口，签署完成后系统会自动调用
        /// </summary>
        /// <param name="flowId"></param>
        /// <returns></returns>
        public async Task<ApiResult<object>> SignFlowArchive(string flowId)
        {
            var result = await Http.PutAsync<
                object,
                object>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/archive",
                new object()
            );
            return result;
        }

        /// <summary>
        /// 流程文档添加
        /// 接口描述 向流程中添加待签署文档，文档必须先用文档管理接口创建，创建方式请参见文件管理接口文档。已经开启的流程不能再添加签署文档.
        /// </summary>
        public async Task<ApiResult<object>> SignFlowAttachmentCreate(string flowId,
            SignFlowAttachmentCreateRequest request)
        {
            var result = await Http.PostAsync<object, SignFlowAttachmentCreateRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/attachments", request
            );
            return result;
        }

        /// <summary>
        /// 流程附件删除
        /// </summary>
        public async Task<ApiResult<object>> SignFlowAttachmentDelete(string flowId, string[] fileIds)
        {
            var result = await Http.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/attachments/fileIds={string.Join(",", fileIds)}"
            );
            return result;
        }

        /// <summary>
        /// 流程附件列表
        /// </summary>
        public async Task<ApiResult<SignFlowAttachmentGetResponse>> SignFlowAttachmentGet(string flowId)
        {
            var result = await Http.GetAsync<SignFlowAttachmentGetResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/attachments"
            );
            return result;
        }

        /// <summary>
        /// 签署流程创建
        /// </summary>
        public async Task<ApiResult<SignFlowCreateResponse>> SignFlowCreate(SignFlowCreateRequest request)
        {
            var result = await Http.PostAsync<SignFlowCreateResponse, SignFlowCreateRequest>(
                $"{Option.BaseUrl}/v1/signflows", request
            );
            return result;
        }

        /// <summary>
        /// 流程文档添加
        /// 接口描述 向流程中添加待签署文档，文档必须先用文档管理接口创建，创建方式请参见文件管理接口文档。已经开启的流程不能再添加签署文档.
        /// </summary>
        public async Task<ApiResult<object>> SignFlowDocumentCreate(string flowId,
            SignFlowDocumentCreateRequest request)
        {
            var result = await Http.PostAsync<object, SignFlowDocumentCreateRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/documents", request
            );
            return result;
        }

        /// <summary>
        /// 流程文档删除
        /// </summary>
        /// <param name="flowId"></param>
        /// <param name="fileIds">文档id列表,多个id使用“，”分隔	</param>
        /// <returns></returns>
        public async Task<ApiResult<object>> SignFlowDocumentDelete(string flowId, string[] fileIds)
        {
            var result = await Http.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/documents/fileIds={string.Join(",", fileIds)}"
            );
            return result;
        }

        /// <summary>
        /// 流程文档下载
        /// </summary>
        public async Task<ApiResult<SignFlowDocumentGetResponse>> SignFlowDocumentGet(string flowId)
        {
            var result = await Http.GetAsync<SignFlowDocumentGetResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/documents"
            );
            return result;
        }

        public async Task<ApiResult<SignFlowDocumentSearchWordsPositionResponse[]>> SignFlowDocumentSearchWordsPosition(
            string flowId,string fileId,string[] keywords)
        {
            var result = await Http.GetAsync<SignFlowDocumentSearchWordsPositionResponse[]>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/documents/{fileId}/searchWordsPosition?keywords={string.Join(",", keywords)}"
            );
            return result;
        }


        public async Task<ApiResult<SignFlowGetResponse>> SignFlowGet(string flowId)
        {
            var result = await Http.GetAsync<SignFlowGetResponse>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}"
            );
            return result;
        }

        /// <summary>
        /// 接口描述 撤销签署流程，撤销后流程中止，所有签署无效。
        /// </summary>
        public async Task<ApiResult<object>> SignFlowRevoke(string flowId, SignFlowRevokeRequest request)
        {
            var result = await Http.PutAsync<
                object,
                SignFlowRevokeRequest>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/revoke",
                request
            );
            return result;
        }

        /// <summary>
        /// 签署流程开启
        /// </summary>
        public async Task<ApiResult<object>> SignFlowStart(string flowId)
        {
            var result = await Http.PutAsync<
                object,
                object>(
                $"{Option.BaseUrl}/v1/signflows/{flowId}/start",
                new object()
            );
            return result;
        }
    }
}