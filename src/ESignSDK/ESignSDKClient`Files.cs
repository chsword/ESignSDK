using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 通过模板创建文件
        /// </summary>
        public async Task<ApiResult<FileCreateByTemplateResponse>> FileCreateByTemplate(
            FileCreateByTemplateRequest request)
        {
            var result = await Http.PostAsync<
                FileCreateByTemplateResponse,
                FileCreateByTemplateRequest>(
                $"{Option.BaseUrl}/v1/files/createByTemplate", request
            );
            return result;
        }

        /// <summary>
        /// 查询文件详情
        /// </summary>
        public async Task<ApiResult<FileGetResponse>> FileGet(string fileId)
        {
            var result = await Http.GetAsync<
                FileGetResponse>(
                $"{Option.BaseUrl}/v1/files/{fileId}"
            );
            return result;
        }

        /// <summary>
        /// 通过上传方式创建文件
        /// </summary>
        public async Task<ApiResult<FileGetUploadUrlResponse>> FileGetUploadUrl(FileGetUploadUrlRequest request)
        {
            var result = await Http.PostAsync<
                FileGetUploadUrlResponse,
                FileGetUploadUrlRequest>(
                $"{Option.BaseUrl}/v1/files/getUploadUrl", request
            );
            return result;
        }

        public async Task<ApiResult<object>> FileUpload(string uploadUrl, byte[] bytes)
        {
            var result = await Http.PutFileAsync(uploadUrl, bytes);
            return result;
        }

        //todo 文件添加数字水印
    }
}