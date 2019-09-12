using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ISaveUser
    {
        public abstract void Execute(UserModel userObj);
    }
}
