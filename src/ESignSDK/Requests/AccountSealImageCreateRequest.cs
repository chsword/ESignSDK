namespace ESignSDK.Requests
{
    public class AccountSealImageCreateRequest
    {
        /// <summary>
        /// 印章别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 印章宽度, 默认95px
        /// </summary>
        public int Width { get; set; } = 95;

        /// <summary>
        /// 印章高度, 默认95px
        /// </summary>
        public int Height { get; set; } = 95;
        public string Type { get; set; } = "BASE64";
        public string Data { get; set; }
        /// <summary>
        /// 	是否对图片进行透明化处理，默认false。对于有背景颜色的图片，建议进行透明化处理，否则可能会遮挡文字
        /// </summary>
        public bool TransparentFlag { get; set; }
    }
}