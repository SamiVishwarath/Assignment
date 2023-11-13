using Data.DbModels;
using Data.Interfaces;

namespace Data.Implementations
{
    public class TitlesRepo: ITitlesRepo
    {
        private readonly PubsContext _context;
        public TitlesRepo(PubsContext context)
        {
            _context = context;
        }

     public List<Title> GetTitles()
        {
            return _context.Titles.ToList();
        }
    }
}
