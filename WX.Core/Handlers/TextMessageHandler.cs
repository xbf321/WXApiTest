using System;

using WX.Framework;
using WX.Model;

namespace WX.Core.Handlers
{
    /// <summary>
    /// 文本相应信息
    /// </summary>
    public class TextMessageHandler : IMessageHandler
    {
        public TextMessageHandler() { }
        public TextMessageHandler(string content) {
            Content = content;
        }
        public string Content { get; set; }

        public Model.ResponseMessage HandlerRequestMessage(Model.MiddleMessage message)
        {
            return new ResponseTextMessage(message.RequestMessage) { 
                CreateTime = DateTime.Now.Ticks,
                Content = Content
            };
        }
    }
}
