using System.Collections.Generic;

namespace ESignSDK.Requests
{
    public class FileCreateByTemplateRequest
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 输入项填充内容，key:value 传入；可使用输入项组件id+填充内容，也可使用输入项组件key+填充内容方式填充
        /// {"甲方:":"测试甲方","乙方:":"测试乙方"},
        /// </summary>
        public Dictionary<string, string> SimpleFormFields { get; set; }

        /// <summary>
        /// 模板编号, 可通过e签宝网站->企业模板下创建和查询	
        /// </summary>
        public string TemplateId { get; set; }
    }
}