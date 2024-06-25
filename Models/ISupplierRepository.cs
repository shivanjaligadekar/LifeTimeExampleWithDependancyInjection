namespace LifeTimeExampleWithDependancyInjection.Models
{
    public interface ISupplierRepository
    {
        public List<SupplierViewModel> GetSuppliers();

        public SupplierViewModel FindSupplier(int id);

        public void Insert(SupplierViewModel supplier);

        public void Delete(int id);
        public void Update(int id, SupplierViewModel supplier);
    }
}
