namespace ESignSDK.Models
{
    public class StructComponent
    {
        /// <summary>
        /// 输入项组件上下文信息，包含了名称，填充格式，样式以及坐标
        /// </summary>
        public StructComponentContext Context { get; set; } = new StructComponentContext();

        /// <summary>
        /// 输入项组件id，使用时可用id填充，为空时表示添加，不为空时表示修改
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 模板下输入项组件唯一标识，使用模板时也可用根据key值填充
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 输入项组件类型，1-文本，2-数字,3-日期，6-签约区
        /// </summary>
        public int Type { get; set; }
    }
}