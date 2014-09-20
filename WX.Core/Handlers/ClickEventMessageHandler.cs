using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WX.Framework;
using WX.Model;

namespace WX.Core.Handlers
{
    //菜单处理机
    public class ClickEventMessageHandler : IMessageHandler
    {
        public ClickEventMessageHandler(string eventKey) {
            EventKey = eventKey;
        }
        public string EventKey { get; set; }
        public Model.ResponseMessage HandlerRequestMessage(Model.MiddleMessage message)
        {
            return new ResponseTextMessage(message.RequestMessage)
            {
                CreateTime = DateTime.Now.Ticks,
                Content = string.Format("点击EventKey:{0}",EventKey,message.RequestMessage.MsgType)
            };
        }
    }
}
