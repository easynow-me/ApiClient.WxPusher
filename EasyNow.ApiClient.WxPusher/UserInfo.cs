namespace EasyNow.ApiClient.WxPusher
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string OpenId { get; set; }
        public string NickName { get; set; }
        public string HeadImg { get; set; }
        public string Sex { get; set; }
        public long? ActiveTime { get; set; }
        public long? LastTime { get; set; }
        public bool Enable { get; set; }
        public long CreateTime { get; set; }
    }
}