using System;
using Newtonsoft.Json;

namespace ESignSDK.Responses
{
    public class ApiResult : ApiResult<object>
    {
    }

    public class ApiResult<T>
    {
        public ReturnTypeCode Code { get; set; }
        public T Data { get; set; }

        [JsonIgnore] public Exception ErrorException { get; set; }

        public string Message { get; set; }

        public static ApiResult<T> Error(Exception exception)
        {
            return new ApiResult<T>
            {
                Code = ReturnTypeCode.Exception,
                ErrorException = exception,
                Message = exception.Message
            };
        }

        public static ApiResult<T> Error(string message)
        {
            return new ApiResult<T>
            {
                Code = ReturnTypeCode.UnknowError,
                Message = message
            };
        }
    }
}