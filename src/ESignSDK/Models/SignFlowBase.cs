namespace ESignSDK.Models
{
    public class SignFlowBase
    {
        /// <summary>
        /// 是否自动归档，默认false
        /// 如设置为true， 则在调用5.1.5签署流程开启后，当所有签署人签署完毕，系统自动将流程归档，状态变为“已完成”状态，
        /// 在流程状态为“已完成”前，可随时添加签署人；
        /// 如设置为false，则在调用5.1.5流程开启后，需主动调用签署流程归档接口，将流程状态变更为“已完成”，
        /// 归档前可随时添加签署人；已完成的流程才可下载签署后的文件
        /// </summary>
        public bool AutoArchive { get; set; } = false;

        /// <summary>
        /// 文件主题
        /// </summary>
        [Required]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 任务配置信息	
        /// </summary>
        public FlowConfigInfo ConfigInfo { get; set; } = new FlowConfigInfo();

        /// <summary>
        /// 文件到期前，提前多少小时回调提醒续签，小时（时间区间：1小时——15天），默认不提醒	
        /// </summary>
        public int ContractRemind { get; set; }

        /// <summary>
        /// 文件有效截止日期,毫秒，默认不失效
        /// </summary>
        public long ContractValidity { get; set; }

        /// <summary>
        /// 发起人账户id，即发起本次签署的操作人个人账号id；如不传，默认由对接平台发起	
        /// </summary>
        public string InitiatorAccountId { get; set; }

        /// <summary>
        /// 发起方主体id，如存在个人代机构发起签约，则需传入机构id；如不传，则默认是对接平台	
        /// </summary>
        public string InitiatorAuthorizedAccountId { get; set; }

        /// <summary>
        /// 签署有效截止日期,毫秒，默认不失效	
        /// </summary>
        public long SignValidity { get; set; }
    }
}