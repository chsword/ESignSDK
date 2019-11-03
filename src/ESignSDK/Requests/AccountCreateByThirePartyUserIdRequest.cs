using System.Runtime.CompilerServices;

namespace ESignSDK.Requests
{
    public class AccountCreateByThirePartyUserIdRequest
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

        /// <summary>
        /// 用户唯一标识，可传入第三方平台的个人用户id、证件号、手机号、邮箱等，
        /// 如果设置则作为账号唯一性字段，相同信息不可重复创建。（个人用户与机构的唯一标识不可重复）	
        /// </summary>
        [Required]
        public string ThirdPartyUserId { get; set; }

    }
}