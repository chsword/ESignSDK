namespace ESignSDK.Requests
{
    public class SignFlowRushSignRequest
    {
        /// <summary>
        /// 催签人账户id	
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// 通知方式，逗号分割，1-短信，2-邮件 3-支付宝 4-钉钉，默认按照走流程设置
        /// "noticeTypes": "1,2",
        /// </summary>
        public string NoticeTypes { get; set; }
        /// <summary>
        /// 被催签人账号id，为空表示：催签当前轮到签署但还未签署的所有签署人	
        /// </summary>
        public string RushsignAccountId { get; set; }
    }

}