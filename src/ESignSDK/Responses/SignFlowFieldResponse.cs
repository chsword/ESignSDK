namespace ESignSDK.Responses
{
    public class SignFlowFieldResponse
    {
        public SignFieldBean[] SignfieldBeans { get; set; }
    }

    public class SignFieldBean
    {
        public string AccountId { get; set; }
        public string FileId { get; set; }
        public string SignfieldId { get; set; }
    }
}