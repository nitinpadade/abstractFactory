using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SaveUser : ISaveUser
    {
        public override void Execute(UserModel userObj)
        {
            Console.WriteLine("Name:" + userObj.Name);
        }
    }
}
