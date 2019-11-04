using System;

namespace ESignSDK.Requests
{
    public class SignAuthOnRequest
    {
        /// <summary>
        /// 如不设置则为永久
        /// </summary>
        public DateTime? Deadline { get; set; }
    }
}