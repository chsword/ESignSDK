namespace ESignSDK.Responses
{
    public class SignFlowDocumentSearchWordsPositionResponse
    {
        public string Keyword { get; set; }
        public string FileId { get; set; }
        public SignFlowDocumentPosition[] PositionList { get; set; }
    }

    public class SignFlowDocumentPosition
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        public SignFlowDocumentCoordinate[] CoordinateList { get; set; }
    }

    public class SignFlowDocumentCoordinate
    {
        public float PosX { get; set; }
        public float PosY { get; set; }
    }

}