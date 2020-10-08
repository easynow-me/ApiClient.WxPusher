using System.Threading.Tasks;
using Refit;

namespace EasyNow.ApiClient.WxPusher
{
    public interface IWxPusher
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        [Post("/api/send/message")]
        Task<Result<MessageResp[]>> SendMessage([Body]MessageReq msg);

        /// <summary>
        /// 查询消息状态
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        [Get("/api/send/query/{messageId}")]
        Task<Result> QueryMessage(int messageId);

        /// <summary>
        /// 创建参数二维码
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [Post("/api/fun/create/qrcode")]
        Task<Result<QrCodeResp>> CreateQrCode([Body]QrCodeReq req);

        /// <summary>
        /// 查询关注用户
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [Get("/api/fun/wxuser")]
        Task<Result<QueryUserResp>> QueryUser([Query] QueryUserReq req);
    }
}