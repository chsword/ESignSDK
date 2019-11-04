namespace ESignSDK.Requests
{
    public class FileGetUploadUrlRequest
    {
        /// <summary>
        /// 所属账号id，即个人账号id或机构账号id，如不传，则默认属于对接平台	
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// 先计算文件md5值，在对该md5值进行base64编码	
        /// </summary>
        [Required]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 目标文件的MIME类型	
        /// </summary>
        [Required]
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        /// 是否转换成pdf文档，默认fasle，代表不做转换。
        /// 转换是异步行为，如果指定要转换，
        /// 需要调用查询文件信息接口查询状态，转换完成后才可使用。	
        /// </summary>
        [Required]
        public bool Convert2Pdf { get; set; } = false;

        /// <summary>
        /// 文件名称（必须带上文件扩展名，不然会导致后续发起流程校验过不去 示例：合同.pdf ）	
        /// </summary>
        [Required]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位byte	
        /// </summary>
        [Required]
        public long FileSize { get; set; }
    }
}