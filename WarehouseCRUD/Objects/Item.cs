using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseCRUD.Objects
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public decimal NettoPrice { get; set; }
        public decimal BruttoPrice { get; set; }
        public int Amount { get; set; }
        public virtual WareHouseDocument WareHouseDocument { get; set; }
    }
}
