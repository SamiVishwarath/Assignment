using Data.DbModels;
using Data.Interfaces;

namespace Data.Implementations
{
    public class SalesRepo : ISalesRepo
    {
        private readonly PubsContext _context;
        public SalesRepo(PubsContext context)
        {
            _context = context;
        }

        List<Sale> ISalesRepo.GetSales(string id)
        {
            return (from d in _context.Sales
                    where id == d.OrdNum
                    select d).ToList();
        }
    }
}

