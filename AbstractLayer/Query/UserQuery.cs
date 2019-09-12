using AbstractLayer.Model;
using AbstractLayer.Parameter;

namespace AbstractLayer.Query
{
    public class UserQuery : IQuery<QueryResult<User>, UserParameter>
    {
        public QueryResult<User> Execute(UserParameter parameters)
        {
            try
            {
                var result = new User
                {
                    Id = 1,
                    Name = "Devansh N Padade",
                    Message = parameters.Id.ToString()
                };

                return new QueryResult<User>()
                {
                    Data = result != null ? result : new User(),
                    IsExecuted = true,
                    Message = "Query Executed Successfully",
                    Status = CommandQueryStatus.Executed
                };
            }
            catch (System.Exception ex)
            {
                return new QueryResult<User>()
                {
                    Data = new User(),
                    IsExecuted = true,
                    Message = "Query Executed Successfully",
                    ErrorMessage = ex.ToString(),
                    Status = CommandQueryStatus.Executed
                };
            }
        }
    }
}
