namespace AbstractLayer
{
    public interface IQuery<TResult, TParameters>
    {
        TResult Execute(TParameters parameters);
    }
}
