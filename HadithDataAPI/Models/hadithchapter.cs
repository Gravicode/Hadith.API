using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "HadithChapter")]
    public class hadithchapter
    {
        [Column(Name = "ChapterID")]
        public int ChapterID { get; set; }

        [Column(Name = "ChapterNo")]
        public int ChapterNo { get; set; }

        [Column(Name = "Title")]
        public string Title { get; set; }

        [Column(Name = "TitleArabic")]
        public string TitleArabic { get; set; }

        [Column(Name = "Intro")]
        public string Intro { get; set; }

        [Column(Name = "PageNo")]
        public int PageNo { get; set; }

        [Column(Name = "HadithID")]
        public int HadithID { get; set; }

        [Column(Name = "ChapterNoStr")]
        public string ChapterNoStr { get; set; }

     
    }
}
