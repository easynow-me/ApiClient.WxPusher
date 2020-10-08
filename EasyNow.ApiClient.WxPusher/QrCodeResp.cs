namespace EasyNow.ApiClient.WxPusher
{
    public class QrCodeResp
    {
        public long Expires { get; set; }
        public string Code { get; set; }
        public string ShortUrl { get; set; }
        public string Extra { get; set; }
        public string Url { get; set; }
    }
}