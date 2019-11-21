using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class AccountModifyResponse : ThirdPartyUser
    {
        public string AccountId { get; set; }
        public string CardNo { get; set; }
        public string ThirdPartyUserId { get; set; }
    }
}