using Data.DbModels;

namespace Data.Interfaces
{
    public interface ISalesRepo
    {
        List<Sale> GetSales(string ord_num);
    }
}
