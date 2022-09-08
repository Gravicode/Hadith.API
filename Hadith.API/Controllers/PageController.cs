using Microsoft.AspNetCore.Mvc;

namespace HadithDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {

        public PageController()
        {

        }


        // GET api/values
        [HttpGet("[action]")]
        public IEnumerable<Hadith.DAL.hadithindex> GetPage(int HadithId)
        {
            var data = Hadith.BLL.HadithData.getIndex(HadithId);
           return data.AsEnumerable();
        }

        [HttpGet("[action]")]
        public Hadith.DAL.hadithindex GetPageByID(int IndexID)
        {
            var data = Hadith.BLL.HadithData.getIndexbyId(IndexID);
            return data;
        }

    }
}
