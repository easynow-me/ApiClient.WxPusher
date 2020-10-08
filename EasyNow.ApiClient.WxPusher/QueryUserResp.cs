namespace EasyNow.ApiClient.WxPusher
{
    public class QueryUserResp
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public UserInfo[] Records { get; set; }
    }
}