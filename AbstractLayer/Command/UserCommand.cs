using AbstractLayer.Model;
using System;

namespace AbstractLayer.Command
{
    public class UserCommand : ICommand<User>
    {
        public User Execute(User obj)
        {
            obj.Message = "Name: " + obj.Name;
            return obj;
        }
    }
}
