using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadith.DAL
{
    [Table(Name = "Hadith")]
    public class hadith
    {

        [Column(Name = "HadithID")]
        public int HadithID { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Title")]
        public string Title { get; set; }

        [Column(Name = "About")]
        public string About { get; set; }

        [Column(Name = "Arabic")]
        public string Arabic { get; set; }

        [Column(Name = "TotalHadith")]
        public int? TotalHadith { get; set; }

        [Column(Name = "TotalPage")]
        public int? TotalPage { get; set; }
    }
}
