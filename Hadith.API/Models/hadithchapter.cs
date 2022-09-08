using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadith.DAL
{
    [Table("HadithChapter")]
    public class hadithchapter
    {
        [Key]
        [Column("ChapterID")]
        public int ChapterID { get; set; }

        [Column("ChapterNo")]
        public int ChapterNo { get; set; }

        [Column("Title")]
        public string? Title { get; set; }

        [Column("TitleArabic")]
        public string TitleArabic { get; set; }

        [Column("Intro")]
        public string Intro { get; set; }

        [Column("PageNo")]
        public int PageNo { get; set; }

        [Column("HadithID")]
        public int HadithID { get; set; }

        [Column("ChapterNoStr")]
        public string ChapterNoStr { get; set; }

     
    }
}
