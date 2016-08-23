using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Collections.ObjectModel;
using Hadith.DAL;
using System.IO;
using Hadith.Tools;
namespace HadithDataAPI.Controllers
{
    public class PageController : ApiController
    {

        public PageController()
        {

        }


        // GET api/values
        [SwaggerOperation("GetPage")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.DAL.hadithindex> GetPage(int HadithId)
        {
            var data = Hadith.BLL.HadithData.getIndex(HadithId);
           return data.AsEnumerable();
        }

        [SwaggerOperation("GetPageByID")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hadith.DAL.hadithindex GetPageByID(int IndexID)
        {
            var data = Hadith.BLL.HadithData.getIndexbyId(IndexID);
            return data;
        }

    }
}
