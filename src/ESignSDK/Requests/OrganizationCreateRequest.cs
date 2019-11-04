namespace ESignSDK.Requests
{
    public class OrganizationCreateRequest : ThirdPartyOrganization
    {
        /// <summary>
        /// 创建人个人账号id（调用个人账号创建接口返回的accountId）
        /// </summary>
        [Required]
        public string Creator { get; set; }

        /// <summary>
        /// 机构唯一标识，可传入第三方平台机构id、企业证件号、
        /// 企业邮箱等如果设置则作为账号唯一性字段，
        /// 相同id不可重复创建。（个人用户与机构的唯一标识不可重复）	
        /// </summary>
        [Required]
        public string ThirdPartyUserId { get; set; }
    }
}