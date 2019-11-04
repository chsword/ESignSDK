using System.Threading.Tasks;
using ESignSDK.Requests;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 个人账号创建
        /// http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E7%AD%BE%E7%BD%B2%E6%96%B9%E4%BF%A1%E6%81%AFAPI/%E4%B8%AA%E4%BA%BA%E8%B4%A6%E5%8F%B7%E5%88%9B%E5%BB%BA.html
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<AccountCreateByThirdPartyUserIdResponse>> AccountCreate(
            AccountCreateRequest request)
        {
            var result = await HttpUtils.PostAsync<
                AccountCreateByThirdPartyUserIdResponse,
                AccountCreateRequest>(
                $"{Option.BaseUrl}/v1/accounts/createByThirdPartyUserId",
                request
            );
            return result;
        }

        /// <summary>
        /// 删除账号
        /// </summary>
        public async Task<ApiResult<object>> AccountDelete(string accountId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}"
            );
            return result;
        }

        /// <summary>
        /// 删除账号
        /// </summary>
        public async Task<ApiResult<object>> AccountDeleteByThirdId(string thirdPartyUserId)
        {
            var result = await HttpUtils.DeleteAsync<object>(
                $"{Option.BaseUrl}/v1/accounts/deleteByThirdId?thirdPartyUserId={thirdPartyUserId}"
            );
            return result;
        }

        /// <summary>
        /// 获取账号
        /// </summary>
        public async Task<ApiResult<AccountModifyResponse>>
            AccountGet(string accountId)
        {
            var result = await HttpUtils.GetAsync<
                AccountModifyResponse>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}"
            );
            return result;
        }

        /// <summary>
        /// 获取账号
        /// </summary>
        public async Task<ApiResult<AccountModifyResponse>> AccountGetByThirdId(string thirdPartyUserId)
        {
            var result = await HttpUtils.GetAsync<
                AccountModifyResponse>(
                $"{Option.BaseUrl}/v1/accounts/getByThirdId?thirdPartyUserId={thirdPartyUserId}"
            );
            return result;
        }

        /// <summary>
        /// 个人账号修改
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<AccountModifyResponse>> AccountModify(string accountId, ThirdPartyUser request)
        {
            var result = await HttpUtils.PutAsync<
                AccountModifyResponse,
                ThirdPartyUser>(
                $"{Option.BaseUrl}/v1/accounts/{accountId}",
                request
            );
            return result;
        }

        /// <summary>
        /// 按三方账号修改
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<AccountModifyResponse>>
            AccountModifyByThirdId(string thirdPartyUserId, ThirdPartyUser request)
        {
            var result = await HttpUtils.PostAsync<
                AccountModifyResponse,
                ThirdPartyUser>(
                $"{Option.BaseUrl}/v1/accounts/updateByThirdId?thirdPartyUserId={thirdPartyUserId}",
                request
            );
            return result;
        }
    }
}