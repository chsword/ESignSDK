using System;

namespace ESignSDK
{
    public class ESignOption
    {
        /// <summary>
        /// 接入域名
        /// </summary>
        public string BaseUrl { get; set; }

        public string AppId { get; set; }
        public string AppKey { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(BaseUrl))
            {
                throw new ArgumentException("接入域名必须填写",nameof(BaseUrl));
            }
            if (string.IsNullOrWhiteSpace(AppId))
            {
                throw new ArgumentException("AppId必须填写", nameof(AppId));
            }
            if (string.IsNullOrWhiteSpace(AppKey))
            {
                throw new ArgumentException("AppKey必须填写", nameof(AppKey));
            }
        }
    }
}
