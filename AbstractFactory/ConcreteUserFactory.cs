using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteUserFactory : UserFactory
    {
        public override UserModel CreateUser(UserModel model)
        {
            return model;
        }

        public override SaveUser SaveUSer()
        {
            return new SaveUser();
        }
    }
}
