namespace ESignSDK.Models
{
    public class StructComponentContext
    {
        /// <summary>
        /// 输入项组件显示名称
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// 输入项组件type=2,type=3时填充格式校验规则;数字格式如：#,#00.0# 日期格式如： yyyy-MM-dd
        /// </summary>
        public string Limit { get; set; }

        public StructComponentContextPos Pos { get; set; } = new StructComponentContextPos();

        /// <summary>
        /// 是否必填，默认true
        /// </summary>
        public bool Required { get; set; } = true;

        /// <summary>
        /// 输入项组件样式
        /// </summary>
        public StructComponentContextStyle Style { get; set; } = new StructComponentContextStyle();
    }
}