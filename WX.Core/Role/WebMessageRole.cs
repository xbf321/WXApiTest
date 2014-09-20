
using WX.Framework;
using WX.Core.Handlers;

namespace WX.Core.Role
{
    /// <summary>
    /// 中转机
    /// </summary>
    public class WebMessageRole : IMessageRole
    {
        //根据MsgType获得相应的处理器
        public IMessageHandler MessageRole(Model.MiddleMessage message)
        {
            IMessageHandler messageHanlder = null;

            switch(message.RequestMessage.MsgType){
                //文本信息
                case Model.MsgType.Text:
                    messageHanlder = new TextMessageRole().MessageRole(message);
                    break;
                //事件信息
                case Model.MsgType.Event:
                    messageHanlder = new EventMessageRole().MessageRole(message);
                    break;
                //找不到情况下，输出默认信息
                default:
                    messageHanlder = new DefaultMessageHandler();
                    break;
            }
            return messageHanlder;
        }
    }
}
