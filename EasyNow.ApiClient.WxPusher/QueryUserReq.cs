using Newtonsoft.Json;
using Refit;

namespace EasyNow.ApiClient.WxPusher
{
    public class QueryUserReq
    {
        [AliasAs("appToken")]
        public string AppToken { get; set; }
        [AliasAs("page")]
        public int Page { get; set; }
        [AliasAs("pageSize")]
        public int PageSize { get; set; }
        [AliasAs("uid")]
        public string Uid { get; set; }
    }
}