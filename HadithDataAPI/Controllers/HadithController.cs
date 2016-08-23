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
    public class HadithController : ApiController
    {
       
        private static ObservableCollection<Hadith.DAL.hadith> HadithData { set; get; }

        public HadithController()
        {
            HadithData = Hadith.BLL.HadithData.getHadiths();
        }

       
        // GET api/values
        [SwaggerOperation("GetHadith")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.DAL.hadith> GetHadith()
        {
            return HadithData.AsEnumerable();
        }

        // GET api/values
        [SwaggerOperation("GetHadithByID")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hadith.DAL.hadith GetHadithByID(int HadithID)
        {
            return Hadith.BLL.HadithData.getHadith(HadithID);
        }

        // GET api/values
        [SwaggerOperation("GetHadithInChapter")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.BLL.HadithContentExt> GetHadithInChapter(int HadithId, int PageNo, int ChapterNo, int LangId)
        {

            var HadithContent = Hadith.BLL.HadithData.getHadithInChapter(HadithId, PageNo, ChapterNo, (Hadith.BLL.HadithData.Languages)LangId);
            return HadithContent.Contents.AsEnumerable();
        }

        // GET api/values/5
        [SwaggerOperation("GoSearch")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.BLL.SearchItem> GoSearch(string Keyword)
        {
            if (string.IsNullOrEmpty(Keyword)) return null;
            var data = Hadith.BLL.HadithData.searchByKeyword(Keyword).AsEnumerable();
            return data;
        }

        // POST api/values
        [SwaggerOperation("GoToSpecificHadith")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hadith.BLL.HadithContentExt GoToSpecificHadith([FromBody]Hadith.BLL.SearchItem item, int LangId)
        {
            if (item != null)
            {
                var HadithContent = Hadith.BLL.HadithData.getHadithInChapter(item.HadithId, item.PageNo, item.ChapterNo.Value, (Hadith.BLL.HadithData.Languages)LangId);


                var temp = (from c in HadithContent.Contents
                            where c.ContentID == item.ContentId
                            select c).SingleOrDefault();
                if (temp != null)
                {

                    return temp;
                }
            }
            return null;
        }
    }
}
