using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 瀑布流布局与无限加载图片相册
{
    public class Photoes
    {
        public int imgUrl { get; set; }
        public string Name { get; set; }
        //模拟数据库有两百条数据
        public static List<Photoes> GetData()
        {
            List<Photoes> list = new List<Photoes>();
            Photoes pic = null;
            for (int i= 21; i <=200; i++)
            {
                pic = new Photoes();
                pic.imgUrl = i;
                pic.Name = "Picture-" + i;
                list.Add(pic);
            }
            return list;
        }
    }
}