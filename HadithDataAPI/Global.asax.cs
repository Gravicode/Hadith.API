using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.IO;
namespace HadithDataAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var PathToDb = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Hadith.db");
            var ConFile = new FileInfo(PathToDb);
            if (ConFile.Exists)
            {
                string ConStr = string.Format("Data Source={0};Version=3;", PathToDb);
                Hadith.BLL.HadithData.Conn = ConStr;

            }
        }
    }
}
