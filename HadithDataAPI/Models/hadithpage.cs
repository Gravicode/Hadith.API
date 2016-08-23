using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "HadithPage")]
    public class hadithpage
    {
        [Column(Name = "PageID")]
        public int PageID { get; set; }

        [Column(Name = "Title")]
        public string Title { get; set; }

        [Column(Name = "TitleArabic")]
        public string TitleArabic { get; set; }

        [Column(Name = "PageNo")]
        public int PageNo { get; set; }

        [Column(Name = "HadithID")]
        public int HadithID { get; set; }

       


    }
}
