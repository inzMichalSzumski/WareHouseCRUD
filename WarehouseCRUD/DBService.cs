using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseCRUD.Objects;

namespace WarehouseCRUD
{
    public class DBService
    {
        private readonly WareHouseContext context;

        public DBService()
        {
            context = new WareHouseContext();
        }

        public List<WareHouseDocument> GetAllDocuments()
        {
            return 
                context.WareHouseDocuments
                .Select(x => x).ToList();
        }

        public void DeleteDocument(Guid wareHouseDocumentId)
        {
            WareHouseDocument wareHouseDocumentToDelete = context.WareHouseDocuments.Where(x => x.WareHouseDocumentId == wareHouseDocumentId).First();
            DeleteItemsOfDocument(wareHouseDocumentToDelete);
            context.WareHouseDocuments
                .Attach(wareHouseDocumentToDelete);
            context.WareHouseDocuments
                .Remove(wareHouseDocumentToDelete);
            context.SaveChanges();
        }

        public void UpdateDocumentById(WareHouseDocument wareHouseDocument)
        {
            WareHouseDocument toUpdate = context.WareHouseDocuments
                .Where(x => x.WareHouseDocumentId == wareHouseDocument.WareHouseDocumentId).First();
            toUpdate = wareHouseDocument;
            context.SaveChanges();
        }

        public void CreateNewDocument(WareHouseDocument wareHouseDocument)
        {
            context.WareHouseDocuments.Add(wareHouseDocument);
            context.SaveChanges();
        }

        public void DeleteItemsOfDocument(WareHouseDocument wareHouseDocument)
        {
            wareHouseDocument.Items.ToList().ForEach(x => context.Items.Attach(x));
            wareHouseDocument.Items.ToList().ForEach(x => context.Items.Remove(x));
            context.SaveChanges();
        }
    }
}
