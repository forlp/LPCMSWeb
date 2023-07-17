using LPCMSWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPCMSWeb.App_Start
{
    public class DataBaseConfig
    {
        public static void Init()
        {
            //实例化一个数据库上下文对象
            CmsDbContext dbcontext = new CmsDbContext();
            //创建数据库如果不存在的话
            if(dbcontext.Database.CreateIfNotExists()){
                Console.WriteLine("数据库已创建成功！");
            }else{
                Console.WriteLine("数据库已存在，无需创建！");
            }
        }
    }
}