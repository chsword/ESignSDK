namespace ESignSDK.Responses
{
    public class FileGetResponse
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>

        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 文件大小，单位byte
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// 文件状态, 0:文件未上传；1:文件上传中 ；2：文件上传已完成,；3：文件上传失败 ；4：文件等待转pdf ；5：文件已转换pdf 。
        /// </summary>
        public int Status { get; set; }
    }
}