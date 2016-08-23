using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "HadithIndex")]
    public class hadithindex
    {
        
        [Column(Name = "IndexID")]
        public int IndexID { get; set; }

        [Column(Name = "HadithID")]
        public int HadithID { get; set; }

        [Column(Name = "No")]
        public int No { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "ArabicName")]
        public string ArabicName { get; set; }

        [Column(Name = "IndexFrom")]
        public int? IndexFrom { get; set; }

        [Column(Name = "IndexTo")]
        public int? IndexTo { get; set; }


    }
}
