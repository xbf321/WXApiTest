using System;

using WX.Framework;
using WX.Model;
using WX.Core.Handlers;

namespace WX.Core.Role
{
    public class EventMessageRole : IMessageRole
    {
        public IMessageHandler MessageRole(Model.MiddleMessage message)
        {
            IMessageHandler messageHanlder = null;

            var eventType = (Event)Enum.Parse(typeof(Event), message.Element.Element("Event").Value, true);

            switch (eventType)
            {
                //订阅
                case Event.Subscribe:
                    messageHanlder = new SubScribeEventMessageHandler();
                    break;
                //取消订阅
                case Event.Unsubscribe:
                    messageHanlder = new UnSubScribeEventMessageHandler();
                    break;
                case Event.Click:
                    //点击菜单时，需要处理
                    messageHanlder = new ClickEventMessageHandler(message.Element.Element("EventKey").Value);
                    break;
            }
            return messageHanlder;
        }
    }
}
