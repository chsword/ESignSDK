namespace ESignSDK.Responses
{
    public class SignFlowExecuteUrlResponse
    {
        /// <summary>
        /// 长链地址(永久有效)	
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 短链地址（30天有效）	
        /// </summary>
        public string ShortUrl { get; set; }
    }

}