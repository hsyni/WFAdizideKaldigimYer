using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAdizideKaldigimYer.Model
{
    [Table("Dizi")]
    public class Dizi
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string DiziAd { get; set; }
        public int SezonNo { get; set; }
        public int BolumNo { get; set; }
        public bool BittiMi { get; set; }

    }
}
