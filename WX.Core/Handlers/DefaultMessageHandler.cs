using System;
using WX.Framework;
using WX.Model;

namespace WX.Core.Handlers
{
    /// <summary>
    /// 默认相应信息
    /// </summary>
    public class DefaultMessageHandler : IMessageHandler
    {
        public Model.ResponseMessage HandlerRequestMessage(Model.MiddleMessage message)
        {
            return new ResponseTextMessage(message.RequestMessage) { 
                CreateTime = DateTime.Now.Ticks,
                Content = "哦哦，没找到相关内容。--("
            };
        }
    }
}
