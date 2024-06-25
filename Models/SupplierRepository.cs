using LifeTimeExampleWithDependancyInjection.Models;
namespace LifeTimeExampleWithDependancyInjection.Models
{
    public class SupplierRepository : ISupplierRepository
    {
        static List<SupplierViewModel> supplierlist = new List<SupplierViewModel>()
        {
            new SupplierViewModel{SuppId=1,SupplierName="Rakshita Enterprises",City="Pune"},
            new SupplierViewModel{SuppId=2,SupplierName="Devraj Enterprises",City="Pune"},
            new SupplierViewModel{SuppId=3,SupplierName="Tanishk Enterprises",City="Pune"},
            new SupplierViewModel{SuppId=4,SupplierName="Ganesh Services",City="Pune"},
            new SupplierViewModel{SuppId=5,SupplierName="Carkeeper Services",City="Pune"}

        };

        public void Delete(int id)
        {
            //throw new NotImplementedException();
            SupplierViewModel model =supplierlist.Find(s=>s.SuppId==id);
            supplierlist.Remove(model); 

        }

        public SupplierViewModel FindSupplier(int id)
        {
            //throw new NotImplementedException();
            SupplierViewModel model = supplierlist.Find(s => s.SuppId == id);
            return model;

        }

        public List<SupplierViewModel> GetSuppliers()
        {
            //throw new NotImplementedException();
            return supplierlist;

        }

        public void Insert(SupplierViewModel supplier)
        {
           // throw new NotImplementedException();
           supplierlist.Add(supplier);
        }

        public void Update(int id, SupplierViewModel supplier)
        {
            //throw new NotImplementedException();
            SupplierViewModel model = supplierlist.Find(s => s.SuppId == id);
            model.SupplierName = supplier.SupplierName;
            model.City = supplier.City;
        }
    }
}
