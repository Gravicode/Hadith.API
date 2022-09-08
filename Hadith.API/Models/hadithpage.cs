using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadith.DAL
{
    [Table("HadithPage")]
    public class hadithpage
    {
        [Key]
        [Column("PageID")]
        public int PageID { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("TitleArabic")]
        public string TitleArabic { get; set; }

        [Column("PageNo")]
        public int PageNo { get; set; }

        [Column("HadithID")]
        public int HadithID { get; set; }

       


    }
}
