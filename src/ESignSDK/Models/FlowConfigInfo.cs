namespace ESignSDK.Models
{
    public class FlowConfigInfo
    {
        /// <summary>
        /// 回调通知地址 ,默认取项目配置通知地址
        ///  "noticeDeveloperUrl":"http://127.0.0.1:9110/notice",
        /// </summary>
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 通知方式，逗号分割，1-短信，2-邮件 。默认值1，请务必请选择一个通知方式，
        /// 否则客户将接收不到流程的签署通知和审批通知，如果流程需要审批，将导致审批无法完成；
        /// 如果客户需要不通知，可以设置noticeType=""
        /// "noticeType":"1,2",
        /// </summary>
        public string NoticeType { get; set; } = "";

        /// <summary>
        /// 签署完成重定向地址,默认签署完成停在当前页面
        ///  "redirectUrl":"http://127.0.0.1:8110/h5/forword",
        /// </summary>
        public string RedirectUrl { get; set; } = "";

        /// <summary>
        /// 签署平台，逗号分割，1-开放服务h5，2-支付宝签 ，默认值1
        /// </summary>
        public string SignPlatform { get; set; } = "1";
    }
}