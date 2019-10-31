namespace ESignSDK.Responses
{
    public class ApiResult<T> where T : class
    {
        public ReturnTypeCode Code { get; set; }
        public string Message { get; set; } 
        public T Data { get; set; }
    }

    public enum ReturnTypeCode
    {
        成功 = 0,

        //个人账号创建
        账号已存在 = 53000000,
        账号不存在 = 53000001,
        账号类型不匹配 = 53000002,

        //修改
        证件信息冲突 = 53000003
    }
}