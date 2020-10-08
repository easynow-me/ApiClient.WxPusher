namespace EasyNow.ApiClient.WxPusher
{
    public class MessageResp
    {
        public string Uid { get; set; }
        public int? TopicId { get; set; }
        public int MessageId { get; set; }
        public int Code { get; set; }
        public string Status { get; set; }
    }
}