using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadith.DAL
{
    [Table("HadithContent")]
    public class hadithcontent
    {
        [Key]
        [Column("ContentID")]
        public int ContentID { get; set; }

        [Column("HadithID")]
        public int HadithID { get; set; }

        [Column("ChapterNo")]
        public int ChapterNo { get; set; }

        [Column("PageNo")]
        public int PageNo { get; set; }

        [Column("Narated")]
        public string Narated { get; set; }

        [Column("ContentEnglish")]
        public string ContentEnglish { get; set; }

        [Column("ContentUrdu")]
        public string ContentUrdu { get; set; }

        [Column("ContentIndonesia")]
        public string ContentIndonesia { get; set; }

        [Column("ContentArabic")]
        public string ContentArabic { get; set; }

        [Column("Grade")]
        public string Grade { get; set; }

        [Column("Reference")]
        public string Reference { get; set; }

        [Column("SanadTop")]
        public string SanadTop { get; set; }

        [Column("SanadBottom")]
        public string SanadBottom { get; set; }

        [Column("HadithOrder")]
        public int HadithOrder { get; set; }

        [Column("BookRef")]
        public string BookRef { get; set; }

        [Column("USCRef")]
        public string USCRef { get; set; }

        [Column("OtherRef")]
        public string OtherRef { get; set; }

        [Column("UrlRef")]
        public string UrlRef { get; set; }

    }
}
