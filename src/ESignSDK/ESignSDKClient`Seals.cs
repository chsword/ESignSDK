using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 个人印章创建
        /// </summary>
        public async Task<ApiResult<SealCreateResponse>> AccountSealCreate(string accountId,
            AccountSealCreateRequest request)
        {
            var result = await HttpUtils.PostAsync<
                SealCreateResponse,
                AccountSealCreateRequest>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}/seals/personaltemplate",
                request
            );
            return result;
        }

        /// <summary>
        /// 删除个人印章
        /// </summary>
        public async Task<ApiResult<object>> AccountSealDelete(string accountId, string sealId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}/seals/{sealId}"
            );
            return result;
        }
        //todo 图片章，暂不考虑

        /// <summary>
        /// 查询 个人印章
        /// </summary>
        public async Task<ApiResult<SealGetResponse>> AccountSealGet(string accountId, int offset = 0, int size = 10)
        {
            var result = await HttpUtils.GetAsync<SealGetResponse>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}/seals?offset={offset}&size={size}"
            );
            return result;
        }

        /// <summary>
        /// 机构印章创建
        /// </summary>
        public async Task<ApiResult<SealCreateResponse>> OrganizationSealCreate(string orgId,
            OrganizationSealCreateRequest request)
        {
            var result = await HttpUtils.PostAsync<
                SealCreateResponse,
                OrganizationSealCreateRequest>(
                $"{Option.BaseUrl}/v1/organizations/{orgId}/seals/officialtemplate",
                request
            );
            return result;
        }

        /// <summary>
        /// 删除机构印章
        /// </summary>
        public async Task<ApiResult<object>> OrganizationSealDelete(string orgId, string sealId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/organizations/{orgId}/seals/{sealId}"
            );
            return result;
        }

        /// <summary>
        /// 查询机构印章
        /// </summary>
        public async Task<ApiResult<SealGetResponse>> OrganizationSealGet(string orgId, int offset = 0, int size = 10)
        {
            var result = await HttpUtils.GetAsync<SealGetResponse>(
                $"{Option.BaseUrl}/v1/organizations/{orgId}/seals?offset={offset}&size={size}"
            );
            return result;
        }
    }
}