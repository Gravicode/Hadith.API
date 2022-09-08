using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadith.DAL
{
    [Table("Hadith")]
    public class hadith
    {
        [Key]
        [Column("HadithID")]
        public int HadithID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("About")]
        public string About { get; set; }

        [Column("Arabic")]
        public string Arabic { get; set; }

        [Column("TotalHadith")]
        public int? TotalHadith { get; set; }

        [Column("TotalPage")]
        public int? TotalPage { get; set; }
    }
}
