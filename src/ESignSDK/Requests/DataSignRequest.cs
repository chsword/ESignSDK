namespace ESignSDK.Requests
{
    public class DataSignRequest
    {
        /// <summary>
        /// 如果是需要使用用户的数字证书进行文本签署，则需要传入用户的账号id，如不传，默认使用平台的数字证书进行文本签署。
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// 待签文本
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 待签文本类型：PLATFORM，平台签 PLATFORM_USER，平台用户签
        /// </summary>
        public string Type { get; set; }


    }
}