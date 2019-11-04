namespace ESignSDK.Requests
{
    public class ThirdPartyOrganization
    {
        /// <summary>
        /// 证件号，默认为空，发起签署前需确保补齐证件号
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型，详见机构证件类型说明 ，默认CRED_ORG_USCC
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// 机构名称	
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 企业法人证件号
        /// </summary>
        public string OrgLegalIdNumber { get; set; }

        /// <summary>
        /// 企业法人名称
        /// </summary>
        public string OrgLegalName { get; set; }
    }
}