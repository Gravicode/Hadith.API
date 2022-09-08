using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadith.DAL
{
    [Table("HadithIndex")]
    public class hadithindex
    {
        [Key]
        [Column("IndexID")]
        public int IndexID { get; set; }

        [Column("HadithID")]
        public int HadithID { get; set; }

        [Column("No")]
        public int No { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("ArabicName")]
        public string ArabicName { get; set; }

        [Column("IndexFrom")]
        public int? IndexFrom { get; set; }

        [Column("IndexTo")]
        public int? IndexTo { get; set; }


    }
}
