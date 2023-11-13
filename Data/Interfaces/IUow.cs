namespace Data.Interfaces
{
    public interface IUow
    {
        ITitlesRepo TitlesRepo { get; }
        ISubmitOrderRepo SubmitOrderRepo { get; }
        ISalesRepo SalesRepo { get; }
    }
}
