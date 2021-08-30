namespace ESignSDK.Responses
{
    public class QuerySignAntPushInfoResponse
    {
        public AntpushlistItem[] AntPushList { get; set; }
        public class AntpushlistItem
        {
            public string DocHash { get; set; }
            public string AntTransactionId { get; set; }
            public string AntTxHash { get; set; }
            public long PushTime { get; set; }
        }

    }
}