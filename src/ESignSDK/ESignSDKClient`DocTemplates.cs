using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 添加输入项组件
        /// </summary>
        /// <returns>添加/编辑的输入项组件id列表</returns>
        public async Task<ApiResult<string[]>> TemplatesComponentCreate(
            string templateId,
            TemplatesComponentCreateRequest request)
        {
            var result = await Http.PostAsync<
                string[],
                TemplatesComponentCreateRequest>(
                $"{Option.BaseUrl}/v1/docTemplates/{templateId}/components", request
            );
            return result;
        }

        /// <summary>
        /// 删除输入项组件
        /// </summary>
        /// <param name="templateId">模板id</param>
        /// <param name="ids">输入项组件id集合，逗号分隔</param>
        /// <returns></returns>
        public async Task<ApiResult<object>> TemplatesComponentDelete(
            string templateId,
            string[] ids)
        {
            var result = await Http.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/docTemplates/{templateId}/components/{string.Join(",", ids)}"
            );
            return result;
        }

        /// <summary>
        /// 查询模板详情
        /// 简要描述：查询模板详情，包括文件模板基本信息和输入项组件信息
        /// </summary>
        public async Task<ApiResult<TemplatesGetResponse>> TemplatesGet(string templateId)
        {
            var result = await Http.GetAsync<TemplatesGetResponse>(
                $"{Option.BaseUrl}/v1/docTemplates/{templateId}"
            );
            return result;
        }

        /// <summary>
        /// 通过上传方式创建模板
        /// </summary>
        public async Task<ApiResult<TemplatesUploadUrlResponse>> TemplatesCreateByUploadUrl(
            FileGetUploadUrlRequest request)
        {
            var result = await Http.PostAsync<
                TemplatesUploadUrlResponse,
                FileGetUploadUrlRequest>(
                $"{Option.BaseUrl}/v1/docTemplates/createByUploadUrl", request
            );
            return result;
        }
    }
}