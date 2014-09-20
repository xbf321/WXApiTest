
namespace WX.Core.Handlers
{
    /// <summary>
    /// 取消订阅时的相应信息
    /// 测试取消订阅时，未输出信息，不清楚是什么情况
    /// </summary>
    public class UnSubScribeEventMessageHandler : TextMessageHandler
    {
        public const string CONTENT = "感谢您的使用，欢迎下次再次订阅！";
        public UnSubScribeEventMessageHandler() : base(CONTENT) { }
    }
}
