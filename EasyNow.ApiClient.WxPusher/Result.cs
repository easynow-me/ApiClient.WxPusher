namespace EasyNow.ApiClient.WxPusher
{
    public class Result
    {
        public int Code { get; set; }
        public string Msg { get; set; }
    }
    
    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
}