using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAdizideKaldigimYer.Model
{
    public class DiziTakipContext : DbContext
    {
        public DbSet<Dizi> Diziler { get; set; }

    }
}
