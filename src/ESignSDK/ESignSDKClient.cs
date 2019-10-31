using System.ComponentModel;
using System.Threading.Tasks;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        /// <summary>
        /// 设置参数
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ESignOption Option { get; set; }

        internal AccessTokenResponse Token  { get; set; }

        public ESignSDKClient(ESignOption option)
        {
            Option = option;
            option.Validate();
        }

        public async Task<ApiResult<AccessTokenResponse>> AccessTokenAsync()
        {
            var ret = await HttpUtils.GetAsync<AccessTokenResponse>(
                $"{Option.BaseUrl}/v1/oauth2/access_token?appId={Option.AppId}&secret={Option.AppKey}&grantType=client_credentials");
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
                $"{Option.BaseUrl}/v1/oauth2/refresh_token?appId={Option.AppId}&grantType=refresh_token&refreshToken={Token.RefreshToken}"
                );
            if (result.Code == 0)
            {
                Token = result.Data;
            }

            return result;
        }

     //   public AccountsCompose Accounts { get; set; }

        /// <summary>
        /// 文件管理-模板
        /// </summary>
        public DocTemplatesCompose DocTemplates { get; set; }

        /// <summary>
        /// 文件管理 -文件
        /// </summary>
        public FilesCompose Files { get; set; }
        

        public OrganizationsCompose Organizations { get; set; }
        public SealsCompose Seals { get; set; }

        public SignFlowsCompose SignFlows { get; set; }
    }

    /// <summary>
    /// 印章相关
    /// </summary>
    public class SealsCompose
    {
    }

    public class DocTemplatesCompose
    {
    }

    public class FilesCompose
    {
    }

    public class OrganizationsCompose
    {
    }
}