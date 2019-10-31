namespace ESignSDK.Responses
{
    public class AccessTokenResponse
    {
        /// <summary>
        /// 有效截止时间（毫秒）	
        /// </summary>
        public string ExpiresIn { get; set; }
        /// <summary>
        /// 授权码
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 刷新授权码, 授权码token即将过期时需要用该刷新授权码获取新的token.	
        /// </summary>
        public string RefreshToken { get; set; }
    }
}