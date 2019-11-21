namespace ESignSDK.Responses
{
    public class SignFlowFieldDeleteResponse
    {
        public SignFlowFieldDeleteResult[] DeleteResults { get; set; }
    }

    public class SignFlowFieldDeleteResult
    {
        public bool Fail { get; set; }
        public string FailedReason { get; set; }

        /// <summary>
        /// 操作结果，0-成功，1-失败
        /// </summary>
        public int OptResult { get; set; }

        public string SignfieldId { get; set; }
        public bool Sucess { get; set; }
    }
}