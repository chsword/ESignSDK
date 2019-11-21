namespace ESignSDK.Models
{
    /// <summary>
    /// 输入项组件样式
    /// </summary>
    public class StructComponentContextStyle
    {
        /// <summary>
        /// 填充字体,默认1，1-宋体，2-新宋体，3-微软雅黑，4-黑体，5-楷体
        /// </summary>
        public int Font { get; set; }

        /// <summary>
        /// 填充字体大小,默认12
        /// </summary>
        public float FontSize { get; set; } = 12;

        /// <summary>
        /// 输入项组件高度
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// 字体颜色，默认#000000黑色
        /// </summary>
        public string TextColor { get; set; } = "#000000";

        /// <summary>
        /// 输入项组件宽度
        /// </summary>
        public float Width { get; set; }
    }
}