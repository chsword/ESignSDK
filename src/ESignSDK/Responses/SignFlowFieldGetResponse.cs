using ESignSDK.Requests;

namespace ESignSDK.Responses
{
    public class SignFlowFieldGetResponse
    {
        public SignFlowFieldGetSignfield[] Signfields { get; set; }
    }

    public class SignFlowFieldGetSignfield
    {
        public int ActorIndentityType { get; set; }
        public bool AddSignTime { get; set; }
        public long AddTime { get; set; }
        public bool AssignedPosbean { get; set; }
        public bool AssignedSeal { get; set; }
        public string AuthorizedAccountId { get; set; }
        public bool AutoExecute { get; set; }

        /// <summary>
        /// 执行失败原因	
        /// </summary>
        public object ExecuteFailedReason { get; set; }

        public string FileId { get; set; }
        public string FlowId { get; set; }
        public int Order { get; set; }
        public SignFieldPosBean PosBean { get; set; }

        /// <summary>
        /// 印章文件file key	
        /// </summary>
        public string SealFileKey { get; set; }

        public string SealId { get; set; }

        /// <summary>
        /// /印章类型，支持多种类型时逗号分割，0-手绘印章，1-模版印章，为空不限制	
        /// </summary>
        public string SealType { get; set; }

        public string SignerAccountId { get; set; }

        /// <summary>
        /// 签署区Id	
        /// </summary>
        public string SignfieldId { get; set; }

        /// <summary>
        /// 签署类型，0-不限，1-单页签署，2-骑缝签署,4-关键字签署，默认1	
        /// </summary>
        public int SignType { get; set; }

        /// <summary>
        /// 签署区状态（0："等待执行，1："执行中"，2："执行失败"，3："审批中"，4： "执行完成"）	
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 状态描述	
        /// </summary>
        public string StatusDescription { get; set; }
    }
}