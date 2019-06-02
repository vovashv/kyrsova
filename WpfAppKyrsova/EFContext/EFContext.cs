using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKyrsova.EFContext
{
    public class EFContext: DbContext
    {
        public EFContext():
            base("DefoultConnection")
        { }
        public DbSet<Answers> Answer { get; set; }
        public DbSet<Questions> Question { get; set; }

    }
}
