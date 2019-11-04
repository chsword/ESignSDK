namespace ESignSDK.Responses
{
    public class FileGetUploadUrlResponse
    {
        /// <summary>
        /// 文件Id
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时
        /// </summary>
        public string UploadUrl { get; set; }
    }
}