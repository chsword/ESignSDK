namespace ESignSDK.Models
{
    public class Seal
    {
        public string Alias { get; set; }

        /// <summary>
        /// 印章创建时间	
        /// </summary>
        public long CreateDate { get; set; }

        /// <summary>
        /// 默认印章标识	
        /// </summary>
        public bool DefaultFlag { get; set; }

        public string FileKey { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// 印章业务类型，CANCELLATION-作废章，COMMON-其它
        /// </summary>
        public string SealBizType { get; set; }

        public string SealId { get; set; }

        /// <summary>
        /// 印章类型，1-机构模板章，2-个人模板章，3-自定义印章，4-手绘章
        /// </summary>
        public int SealType { get; set; }

        public string Url { get; set; }
        public int Width { get; set; }
    }
}