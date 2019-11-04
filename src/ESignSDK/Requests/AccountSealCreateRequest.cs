namespace ESignSDK.Requests
{
    public class AccountSealCreateRequest
    {
        /// <summary>
        /// 印章别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 印章颜色，RED-红色， BLUE-蓝色，BLACK-黑色
        /// </summary>
        public string Color { get; set; } = "RED";

        /// <summary>
        /// 印章高度, 默认95px
        /// </summary>
        public int Height { get; set; } = 95;

        /// <summary>
        /// 模板类型, 详见个人印章样式说明 SQUARE, BORDERLESS, FZKC, HWLS, HWXK, HWXKBORDER, HYLSF, RECTANGLE, YGYJFCS, YGYMBXS, YYGXSF;
        /// 默认设置一种 华文行楷
        /// </summary>
        public string Type { get; set; } = "HWXK";

        /// <summary>
        /// 印章宽度, 默认95px
        /// </summary>
        public int Width { get; set; } = 95;
    }
}