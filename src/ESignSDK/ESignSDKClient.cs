using System.ComponentModel;
using ESignSDK.Responses;

namespace ESignSDK
{
    public partial class ESignSDKClient
    {
        public ESignSDKClient(ESignOption option)
        {
            Option = option;
            option.Validate();
            Http = new HttpUtils(this);
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal ESignOption Option { get; set; }

        internal AccessTokenResponse Token { get; set; }
        HttpUtils Http { get; set; }
    }
}