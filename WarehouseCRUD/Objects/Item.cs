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
        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
                PublicName = $"{name} x {amount}";
            }
        }
        public string PublicName { get; set; }
        public decimal NettoPrice { get; set; }
        public decimal BruttoPrice { get; set; }
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                PublicName = $"{name} x {amount}";
            }
        }
        public virtual WareHouseDocument WareHouseDocument { get; set; }
    }
}
