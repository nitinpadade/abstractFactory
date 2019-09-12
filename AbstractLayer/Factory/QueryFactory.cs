namespace AbstractLayer.Factory
{
    public abstract class QueryFactory
    {
        public abstract IQuery<TResult, TParameters> CreateFactory<TResult, TParameters, TCls>()
             where TResult : class
             where TParameters : class
             where TCls : class;
    }
}
