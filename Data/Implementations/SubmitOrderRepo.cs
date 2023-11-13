using Data.DbModels;
using Data.Interfaces;

namespace Data.Implementations
{
    public class SubmitOrderRepo : ISubmitOrderRepo
    {
        private readonly PubsContext _context;
        public SubmitOrderRepo(PubsContext context)
        {
            _context = context;
        }

        public void SubmitOrder(string title, int qty)
        {
            var store = _context.Titles.Select(a => a).Where(b => b.Title1 == title).FirstOrDefault();

            // now get the store id based on above title id
            var titleid = store.TitleId;

            var salerecord = _context.Sales.Select(a => a).Where(x => x.TitleId == titleid).FirstOrDefault();

            Sale sale = new Sale();
            Title ti = new Title();
            ti = store;
            sale.Title = ti;
            sale.TitleId = titleid;
            sale.StorId = salerecord.StorId;
            sale.Qty = (short)qty;
            sale.OrdNum = "testO1";
            sale.Payterms = salerecord.Payterms;
            sale.OrdDate = DateTime.Now;

            SaveOrder(sale);

        }
        private bool SaveOrder(Sale Book)
        {
            _context.Sales.Add(Book);
            _context.SaveChanges();
            return true;
        }

    }
}
