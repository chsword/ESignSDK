namespace ESignSDK.Models
{
    public class ThirdPartyUser
    {
        /// <summary>
        /// 邮箱地址，默认空
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 证件号，默认为空，发起签署前需确保补齐证件号
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型,详见个人证件类型说明 ，默认CRED_PSN_CH_IDCARD
        /// </summary>
        public string IdType { get; set; } = CredPsnType.CRED_PSN_CH_IDCARD;

        /// <summary>
        /// 手机号码，默认空，手机号为空时无法使用短信意愿认证
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名，
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}