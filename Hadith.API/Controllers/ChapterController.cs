using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace HadithDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        
        public ChapterController()
        {

        }

        [HttpGet("[action]")]
        // GET api/values
        
        public IEnumerable<Hadith.DAL.hadithchapter> GetChapter(int HadithId, int PageNo)
        {
            var data = Hadith.BLL.HadithData.getChapters(HadithId, PageNo);
            return data.AsEnumerable();
        }

        // GET api/values
        [HttpGet("[action]")]
        public Hadith.DAL.hadithchapter GetChapterByID(int HadithId, int PageNo,int ChapterNo)
        {
            var data = Hadith.BLL.HadithData.getChapter(HadithId, PageNo,ChapterNo);
            return data;
        }
    }
}
