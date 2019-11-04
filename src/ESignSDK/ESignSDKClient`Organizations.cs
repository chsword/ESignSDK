using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    /// <summary>
    /// Organizations
    /// </summary>
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 机构账号创建
        /// </summary>
        public async Task<ApiResult<OrganizationCreateResponse>> OrganizationCreate(OrganizationCreateRequest request)
        {
            var result = await HttpUtils.PostAsync<
                OrganizationCreateResponse,
                OrganizationCreateRequest>(
                $"{Option.BaseUrl}/v1/organizations/createByThirdPartyUserId",
                request
            );
            return result;
        }


        /// <summary>
        /// 删除账号
        /// </summary>
        public async Task<ApiResult<object>> OrganizationDelete(string orgId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/organizations/{orgId}"
            );
            return result;
        }

        /// <summary>
        /// 删除账号
        /// </summary>
        public async Task<ApiResult<object>> OrganizationDeleteByThirdId(string thirdPartyUserId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/organizations/deleteByThirdId?thirdPartyUserId={thirdPartyUserId}"
            );
            return result;
        }


        /// <summary>
        /// 获取账号
        /// </summary>
        public async Task<ApiResult<OrganizationModifyResponse>>
            OrganizationGet(string accountId)
        {
            var result = await HttpUtils.GetAsync<
                OrganizationModifyResponse>(
                $"{Option.BaseUrl}/v1/organizations/{accountId}"
            );
            return result;
        }

        /// <summary>
        /// 获取账号
        /// </summary>
        public async Task<ApiResult<OrganizationModifyResponse>> OrganizationGetByThirdId(
            string thirdPartyUserId)
        {
            var result = await HttpUtils.GetAsync<
                OrganizationModifyResponse>(
                $"{Option.BaseUrl}/v1/organizations/getByThirdId?thirdPartyUserId={thirdPartyUserId}"
            );
            return result;
        }


        /// <summary>
        /// 按ID修改机构账号
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<OrganizationModifyResponse>> OrganizationModify(
            string orgId, ThirdPartyOrganization request)
        {
            var result = await HttpUtils.PutAsync<
                OrganizationModifyResponse,
                ThirdPartyOrganization>(
                $"{Option.BaseUrl}/v1/organizations/{orgId}",
                request
            );
            return result;
        }

        /// <summary>
        /// 按三方ID修改机构账号
        /// </summary>
        public async Task<ApiResult<OrganizationModifyResponse>> OrganizationModifyByThirdId(
            string thirdPartyUserId, ThirdPartyOrganization request)
        {
            var result = await HttpUtils.PostAsync<
                OrganizationModifyResponse,
                ThirdPartyOrganization>(
                $"{Option.BaseUrl}/v1/organizations/updateByThirdId?thirdPartyUserId={thirdPartyUserId}",
                request
            );
            return result;
        }
    }
}