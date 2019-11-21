using System.Collections.Generic;

namespace ESignSDK.Requests
{
    public class SignFlowFieldAddPlatformRequest
    {
        /// <summary>
        /// 签署区列表数据	
        /// </summary>
        public List<SignField> Signfields { get; set; }
    }

    public class SignField
    {
        /// <summary>
        /// 文件file id	
        /// </summary>
        [Required]
        public string FileId { get; set; }

        /// <summary>
        /// 签署顺序，默认1,且不小于1，顺序越小越先处理	
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 签署区位置信息, （signType为1时, 页码和XY坐标不能为空, signType为2时, 页码和Y坐标不能为空）
        /// </summary>
        public SignFieldPosBean PosBean { get; set; }

        /// <summary>
        /// 印章id， 仅限企业公章，暂不支持指定企业法定代表人印章	
        /// </summary>
        [Required]
        public string SealId { get; set; }

        /// <summary>
        /// 签署类型， 1-单页签署，2-骑缝签署，默认1	
        /// </summary>
        public int SignType { get; set; }

        /// <summary>
        /// 第三方业务流水号id，保证相同签署人、相同签约主体、相同签署顺序的任务，对应的第三方业务流水id唯一，默认空	
        /// </summary>
        public string ThirdOrderNo { get; set; }
    }

    public class SignFieldPosBean
    {
        /// <summary>
        /// 是否添加签署时间戳, 默认不添加 ，格式 2019-03-11 10：12：12
        /// </summary>
        public bool? AddSignTime { get; set; }

        /// <summary>
        /// 页码信息，当签署区signType为2时, 页码可以'-'分割, 其他情况只能是数字	
        /// </summary>
        public string PosPage { get; set; }

        public float PosX { get; set; }
        public float PosY { get; set; }

        /// <summary>
        /// 签署区宽，默认印章宽度	
        /// </summary>
        public float? Width { get; set; }
    }
}