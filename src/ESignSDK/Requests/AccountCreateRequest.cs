namespace ESignSDK.Requests
{
    public class AccountCreateRequest : ThirdPartyUser
    {
        /// <summary>
        /// 用户唯一标识，可传入第三方平台的个人用户id、证件号、手机号、邮箱等，
        /// 如果设置则作为账号唯一性字段，相同信息不可重复创建。（个人用户与机构的唯一标识不可重复）	
        /// </summary>
        [Required]
        public string ThirdPartyUserId { get; set; }
    }
}