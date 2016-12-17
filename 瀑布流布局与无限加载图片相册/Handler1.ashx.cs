using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace 瀑布流布局与无限加载图片相册
{
    /// <summary>
    /// 服务器返回数据给客户端的一般处理程序
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            List<Photoes> result = Photoes.GetData();
            int pageIndex = Convert.ToInt32(context.Request["page"]);
            var filtered = result.Where(p => p.imgUrl >= pageIndex * 20 - 19 && p.imgUrl <= pageIndex * 20).ToList();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string jsonData = ser.Serialize(filtered);
            context.Response.Write(jsonData);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}