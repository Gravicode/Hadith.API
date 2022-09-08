using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace HadithDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {

        public LanguageController()
        {

        }


        // GET api/values
        [HttpGet("[action]")]
        public IEnumerable<Hadith.DAL.language> GetLanguage()
        {
            var data = Hadith.BLL.HadithData.getLanguage();
            return data.AsEnumerable();
        }

        // GET api/values
        [HttpGet("[action]")]
        public Hadith.DAL.language GetLanguageByID(int LangID)
        {
            var data = Hadith.BLL.HadithData.getLanguage(LangID);
            return data;
        }

    }
}
