namespace ESignSDK.Requests
{
    public class SignFlowRevokeRequest
    {
        /// <summary>
        /// 发起人账户id，即发起本次签署的操作人个人账号id；如不传，默认由对接平台发起	
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 撤销原因,默认"撤销"	
        /// </summary>
        public string RevokeReason { get; set; } = "撤销";
    }
}