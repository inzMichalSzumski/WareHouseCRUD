using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseCRUD.Objects;

namespace WarehouseCRUD
{
    public class WareHouseContext : DbContext
    {
        public DbSet<WareHouseDocument> WareHouseDocuments { get; set; }
        public DbSet<Item> Items { get; set; }


    }
}
