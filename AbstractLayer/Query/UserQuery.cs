using AbstractLayer.Model;
using AbstractLayer.Parameter;

namespace AbstractLayer.Query
{
    public class UserQuery : IQuery<User, UserParameter>
    {
        public User Execute(UserParameter parameters)
        {
            return new User { Id = 1, Name = "Devansh N Padade", Message = parameters.Id.ToString() };
        }
    }
}
