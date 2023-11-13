using Data.DbModels;
using Data.Interfaces;
namespace Data.Implementations;

public class Uow : IUow
{
    private readonly PubsContext _context;
    public Uow(PubsContext context)
    {
        _context = context;
    }
    
    public ISubmitOrderRepo SubmitOrderRepo
    {
        get
        {
            return new SubmitOrderRepo(_context);
        }
    }

    public ISalesRepo SalesRepo
    {
        get
        {
            return new SalesRepo(_context);
        }
    }

    public ITitlesRepo TitlesRepo
    {
        get
        {
            return new TitlesRepo(_context);
        }

    }
   
}
