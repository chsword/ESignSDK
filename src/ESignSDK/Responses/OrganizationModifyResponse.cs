using ESignSDK.Requests;

namespace ESignSDK.Responses
{
    public class OrganizationModifyResponse : ThirdPartyOrganization
    {
        public string OrgId { get; set; }
        public string ThirdPartyUserId { get; set; }
    }
}