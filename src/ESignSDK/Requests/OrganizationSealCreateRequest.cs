namespace ESignSDK.Requests
{
    public class OrganizationSealCreateRequest
    {
        /// <summary>
        /// 印章别名	
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 中心图案类型，STAR-圆形有五角星，NONE-圆形无五角星， 详见机构印章样式说明
        /// </summary>
        public string Central { get; set; } = "NONE";

        /// <summary>
        /// 印章颜色，RED-红色，BLUE-蓝色，BLACK-黑色	
        /// </summary>
        public string Color { get; set; } = "RED";

        /// <summary>
        /// 印章高度，默认159px
        /// </summary>
        public int Height { get; set; } = 159;

        /// <summary>
        /// 横向文	 最多8个字
        /// </summary>
        public string Htext { get; set; }

        /// <summary>
        /// 下弦文
        /// </summary>
        public string Qtext { get; set; }

        /// <summary>
        /// 模板类型，TEMPLATE_ROUND-圆章，TEMPLATE_OVAL-椭圆章， 详见机构印章样式说明
        /// </summary>
        public string Type { get; set; } = "TEMPLATE_ROUND";

        public int Width { get; set; } = 159;
    }
}