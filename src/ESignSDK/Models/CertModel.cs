namespace ESignSDK.Models
{
    public class CertModel
    {
        /// <summary>
        /// 所有者
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 发布者名称
        /// </summary>
        public string IssuerCN { get; set; }
    }
}