namespace ESignSDK.Models
{
    public class SignFlowDocumentWithSetting
    {
        /// <summary>
        /// 是否加密，0-不加密，1-加，默认0
        /// </summary>
        public int Encryption { get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [Required]
        public string FileId { get; set; }

        /// <summary>
        /// 文档名称,默认文件名称	
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文档密码, 如果encryption值为1, 文档密码不能为空，默认没有密码	
        /// </summary>
        public string FilePassword { get; set; }
    }
}