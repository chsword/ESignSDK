namespace ESignSDK.Requests
{
    public class CheckAntfinNotaryRequest
    {
        [Required]
        public string DocHash { get; set; }
        [Required]
        public string AntTxHash { get; set; }
    }
}