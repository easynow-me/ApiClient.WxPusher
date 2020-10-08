namespace EasyNow.ApiClient.WxPusher
{
    public class MessageReq
    {
        public string AppToken { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 消息摘要，显示在微信聊天页面或者模版消息卡片上，限制长度100，可以不传，不传默认截取content前面的内容。
        /// </summary>
        public string Summary { get; set; }
        public ContentType ContentType { get; set; }
        public int[] TopicIds { get; set; }
        public string[] Uids { get; set; }
        public string Url { get; set; }
    }
}