using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WX.Core.Handlers
{
    /// <summary>
    /// 订阅时，输出的信息
    /// </summary>
    public class SubScribeEventMessageHandler : TextMessageHandler
    {
        private const string CONTENT = "欢迎订阅此微信号！";
        public SubScribeEventMessageHandler() : base(CONTENT) { }
    }
}
