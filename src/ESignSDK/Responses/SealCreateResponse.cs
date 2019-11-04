namespace ESignSDK.Responses
{
    public class SealCreateResponse
    {
        /// <summary>
        /// 印章fileKey	
        /// </summary>
        public string FileKey { get; set; }

        public int? Height { get; set; }

        /// <summary>
        /// 印章id	
        /// </summary>
        public string SealId { get; set; }

        /// <summary>
        /// 印章下载地址, 有效时间1小时	
        /// </summary>
        public string Url { get; set; }

        public int? Width { get; set; }
    }
}