using System.Collections.Generic;
using ESignSDK.Models;

namespace ESignSDK.Responses
{
    public class SealGetResponse
    {
        public List<Seal> Seals { get; set; }
        public int Total { get; set; }
    }
}