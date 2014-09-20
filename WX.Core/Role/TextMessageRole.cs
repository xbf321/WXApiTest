
using WX.Framework;
using WX.Model;
using WX.Core.Handlers;

namespace WX.Core.Role
{
    /// <summary>
    /// 文本处理规则
    /// </summary>
    public class TextMessageRole : IMessageRole
    {
        public IMessageHandler MessageRole(Model.MiddleMessage message)
        {
            var request = (RequestTextMessage)message.RequestMessage;
            return new TextMessageHandler(string.Format("已收到消息:{0}",request.Content));
        }
    }
}
