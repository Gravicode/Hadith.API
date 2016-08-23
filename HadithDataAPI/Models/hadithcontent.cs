using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "HadithContent")]
    public class hadithcontent
    {  
        [Column(Name = "ContentID")]
        public int ContentID { get; set; }

        [Column(Name = "HadithID")]
        public int HadithID { get; set; }

        [Column(Name = "ChapterNo")]
        public int ChapterNo { get; set; }

        [Column(Name = "PageNo")]
        public int PageNo { get; set; }

        [Column(Name = "Narated")]
        public string Narated { get; set; }

        [Column(Name = "ContentEnglish")]
        public string ContentEnglish { get; set; }

        [Column(Name = "ContentUrdu")]
        public string ContentUrdu { get; set; }

        [Column(Name = "ContentIndonesia")]
        public string ContentIndonesia { get; set; }

        [Column(Name = "ContentArabic")]
        public string ContentArabic { get; set; }

        [Column(Name = "Grade")]
        public string Grade { get; set; }

        [Column(Name = "Reference")]
        public string Reference { get; set; }

        [Column(Name = "SanadTop")]
        public string SanadTop { get; set; }

        [Column(Name = "SanadBottom")]
        public string SanadBottom { get; set; }

        [Column(Name = "HadithOrder")]
        public int HadithOrder { get; set; }

        [Column(Name = "BookRef")]
        public string BookRef { get; set; }

        [Column(Name = "USCRef")]
        public string USCRef { get; set; }

        [Column(Name = "OtherRef")]
        public string OtherRef { get; set; }

        [Column(Name = "UrlRef")]
        public string UrlRef { get; set; }

    }
}
