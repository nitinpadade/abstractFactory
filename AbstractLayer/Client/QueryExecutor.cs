using AbstractLayer.Factory;

namespace AbstractLayer.Client
{
    public class QueryExecutor : IQueryExecutor
    {
        readonly QueryFactory _factory = null;
        public QueryExecutor(QueryFactory factory)
        {
            _factory = factory;
        }

        public TResult Execute<TCls, TResult, TParameters>(TParameters parameters)
            where TCls : class
            where TResult : class
            where TParameters : class
        {
            var _handler = _factory.CreateFactory<TResult, TParameters, TCls>();
            return _handler.Execute(parameters);
        }
    }
}
