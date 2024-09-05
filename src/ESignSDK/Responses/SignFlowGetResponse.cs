using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class SignFlowGetResponse : SignFlowBase
    {
        /// <summary>
        /// 发起签署流程的应用Id	
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 流程描述, 如果流程已拒签或已撤回, 并且存在拒签或撤回原因,
        /// 流程描述显示为原因, 否则默认为流程状态描述	
        /// </summary>
        public string FlowDesc { get; set; }

        /// <summary>
        /// 流程结束时间	
        /// </summary>
        public string FlowEndTime { get; set; }

        /// <summary>
        /// 流程Id	
        /// </summary>
        public string FlowId { get; set; }

        /// <summary>
        /// 流程开始时间	
        /// </summary>
        public string FlowStartTime { get; set; }



        public int FlowStatus { get; set; }
    }
}