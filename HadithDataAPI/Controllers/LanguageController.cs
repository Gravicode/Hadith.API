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
    public class LanguageController : ApiController
    {

        public LanguageController()
        {

        }


        // GET api/values
        [SwaggerOperation("GetLanguage")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<Hadith.DAL.language> GetLanguage()
        {
            var data = Hadith.BLL.HadithData.getLanguage();
            return data.AsEnumerable();
        }

        // GET api/values
        [SwaggerOperation("GetLanguageByID")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hadith.DAL.language GetLanguageByID(int LangID)
        {
            var data = Hadith.BLL.HadithData.getLanguage(LangID);
            return data;
        }

    }
}
