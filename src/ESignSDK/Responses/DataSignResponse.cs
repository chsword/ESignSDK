namespace ESignSDK.Responses
{
    public class DataSignResponse
    {
        /// <summary>
        /// 签署结果，请注意保存，后续可根据该参数进行验签
        /// </summary>

        public string SignlogId { get; set; }
        /// <summary>
        /// 签署记录编号，请注意保存
        /// </summary>
        public string SignResult { get; set; }
     

    }
}