using Data.DbModels;

namespace Data.Interfaces
{
    public interface ITitlesRepo
    {
      List<Title> GetTitles();
    }
}
