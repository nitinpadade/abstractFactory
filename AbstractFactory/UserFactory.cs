using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class UserFactory
    {
        public abstract UserModel CreateUser(UserModel model);
        public abstract SaveUser SaveUSer();
    }
}
