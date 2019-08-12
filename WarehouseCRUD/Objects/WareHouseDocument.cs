using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseCRUD.Objects
{
    public class WareHouseDocument
    {
        public Guid WareHouseDocumentId { get; set; }
        public DateTime? Created { get; set; }
        public int ClientNumber { get; set; }
        public string DocumentName { get; set; }
        public int SumNetto { get; set; }
        public int SumBrutto { get; set; }
        public List<Item> Items { get; set; }
    }
}
