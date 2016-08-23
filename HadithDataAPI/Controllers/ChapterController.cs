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
    public class ChapterController : ApiController
    {
        
        public ChapterController()
        {

        }


        // GET api/values
        [SwaggerOperation("GetChapter")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.DAL.hadithchapter> GetChapter(int HadithId, int PageNo)
        {
            var data = Hadith.BLL.HadithData.getChapters(HadithId, PageNo);
            return data.AsEnumerable();
        }

        // GET api/values
        [SwaggerOperation("GetChapterByID")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hadith.DAL.hadithchapter GetChapterByID(int HadithId, int PageNo,int ChapterNo)
        {
            var data = Hadith.BLL.HadithData.getChapter(HadithId, PageNo,ChapterNo);
            return data;
        }
    }
}
