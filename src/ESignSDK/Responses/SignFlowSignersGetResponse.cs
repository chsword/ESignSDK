namespace ESignSDK.Responses
{
    public class SignFlowSignersGetResponse
    {
        public SignFlowSigner[] Signers { get; set; }
    }

    public class SignFlowSigner
    {
        public int SignOrder { get; set; }
        /// <summary>
        /// 签署状态, 0-待签, 1-未签, 2-已签 3-待审批 4-拒签	
        /// </summary>
        public int SignStatus { get; set; }
        /// <summary>
        /// 签约主体的账号id（个人/企业）；
        /// 如签署人本签署，则返回签署人账号id；
        /// 如签署人代机构签署，则返回机构账号id	
        /// </summary>
        public string SignerAccountId { get; set; }
        public string SignerAuthorizedAccountId { get; set; }
        public string SignerAuthorizedAccountName { get; set; }
        /// <summary>
        /// 签署主体是否已实名	
        /// </summary>
        public bool SignerAuthorizedAccountRealName { get; set; }
        /// <summary>
        /// 签署主体类型, 0-个人, 1-机构	
        /// </summary>
        public int SignerAuthorizedAccountType { get; set; }
        public string SignerName { get; set; }
        /// <summary>
        /// 签署人是否已实名	
        /// </summary>
        public bool SignerRealName { get; set; }
        /// <summary>
        /// 本次签署任务对应指定的第三方业务流水号id，当存在多个第三方业务流水号id时，返回多个，并逗号隔开	
        /// </summary>
        public string ThirdOrderNo { get; set; }
    }

}