using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;

namespace HadithDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HadithController : ControllerBase
    {
       
        private static ObservableCollection<Hadith.DAL.hadith> HadithData { set; get; }

        public HadithController()
        {
            HadithData = Hadith.BLL.HadithData.getHadiths();
        }


        [HttpGet("[action]")]
        public IEnumerable<Hadith.DAL.hadith> GetHadith()
        {
            return HadithData.AsEnumerable();
        }

        // GET api/values
        [HttpGet("[action]")]
        public Hadith.DAL.hadith GetHadithByID(int HadithID)
        {
            return Hadith.BLL.HadithData.getHadith(HadithID);
        }

        // GET api/values
        [HttpGet("[action]")]
        public IEnumerable<Hadith.BLL.HadithContentExt> GetHadithInChapter(int HadithId, int PageNo, int ChapterNo, int LangId)
        {

            var HadithContent = Hadith.BLL.HadithData.getHadithInChapter(HadithId, PageNo, ChapterNo, (Hadith.BLL.HadithData.Languages)LangId);
            return HadithContent.Contents.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("[action]")]
        public IEnumerable<Hadith.BLL.SearchItem> GoSearch(string Keyword)
        {
            if (string.IsNullOrEmpty(Keyword)) return null;
            var data = Hadith.BLL.HadithData.searchByKeyword(Keyword).AsEnumerable();
            return data;
        }

        // POST api/values
        [HttpGet("[action]")]
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
