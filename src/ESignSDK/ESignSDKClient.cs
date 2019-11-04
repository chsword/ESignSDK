using System.ComponentModel;
using System.Threading.Tasks;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        public ESignSDKClient(ESignOption option)
        {
            Option = option;
            option.Validate();
            HttpUtils = new HttpUtils(this);
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal ESignOption Option { get; set; }

        internal AccessTokenResponse Token { get; set; }
        HttpUtils HttpUtils { get; set; }

        public async Task<ApiResult<AccessTokenResponse>> AccessTokenAsync()
        {
            var ret = await HttpUtils.GetAsync<AccessTokenResponse>(
                $"{Option.BaseUrl}/v1/oauth2/access_token?appId={Option.AppId}&secret={Option.AppKey}&grantType=client_credentials",
                false);
            if (ret.Code == 0)
            {
                Token = ret.Data;
            }

            return ret;
        }

        public async Task<ApiResult<AccessTokenResponse>> RefreshTokenAsync()
        {
            if (Token == null || string.IsNullOrWhiteSpace(Token.RefreshToken))
            {
                var ret = await AccessTokenAsync();
                return ret;
            }

            var result = await HttpUtils.GetAsync<AccessTokenResponse>(
                $"{Option.BaseUrl}/v1/oauth2/refresh_token?appId={Option.AppId}&grantType=refresh_token&refreshToken={Token.RefreshToken}",
                false
            );
            if (result.Code == 0)
            {
                Token = result.Data;
            }

            return result;
        }
    }
}