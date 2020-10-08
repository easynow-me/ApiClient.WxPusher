namespace EasyNow.ApiClient.WxPusher
{
    public class QrCodeReq
    {
        public string AppToken { get; set; }
        public string Extra { get; set; }
        /// <summary>
        /// 可选，二维码的有效期，默认30分钟，最长30天，单位是秒
        /// </summary>
        public int ValidTime { get; set; }
    }
}