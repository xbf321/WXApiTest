using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

using WX.Model;
using WX.Core.Role;

namespace WX.Web.WWW.Controllers
{
    public class WXController : Controller
    {
        //
        // GET: /wx/callback
        public ActionResult Callback()
        {
            if (Request.HttpMethod == "POST")
            {
                var reader = XmlReader.Create(Request.InputStream);

                var doc = XDocument.Load(reader);
                var xml = doc.Element("xml");
                var msg = new MiddleMessage(xml);
                //把inputstream转换成xelement后，直接交给WebMessageRole来处理吧
                var responseMessage = new WebMessageRole()
                    .MessageRole(msg)
                    .HandlerRequestMessage(msg);

                if (responseMessage != null)
                {
                    return Content(responseMessage.Serializable());
                }
                return Content("Error");
            }
            else {
                //需要检查签名
                //测试阶段暂时没处理
                return Content(Request.QueryString["echostr"]);
            }
        }

    }
}
