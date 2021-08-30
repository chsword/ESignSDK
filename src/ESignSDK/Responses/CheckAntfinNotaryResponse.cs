namespace ESignSDK.Responses
{
    public class CheckAntfinNotaryResponse
    {
        public string DocHash { get; set; }
        public int BlockHeight { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public long NotaryTime { get; set; }
        public string NotaryType { get; set; }
        public string Phase { get; set; }
        public bool Result { get; set; }
        public string AntTransactionId { get; set; }
        public string AntTxHash { get; set; }
    }

}