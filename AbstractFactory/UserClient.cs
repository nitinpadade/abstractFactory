using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class UserClient
    {
        private UserModel _userModel;
        private SaveUser _userSave;
        // Constructor

        public UserClient(UserFactory factory, UserModel userModel)
        {
            _userModel = factory.CreateUser(userModel);
            _userSave = factory.SaveUSer();
        }

        public void Run()
        {
            _userSave.Execute(_userModel);
        }
    }
}
