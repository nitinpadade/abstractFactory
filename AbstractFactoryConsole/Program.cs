using AbstractLayer.Client;
using AbstractLayer.Command;
using AbstractLayer.Factory;
using AbstractLayer.Model;
using System;


namespace AbstractFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var factory = new ConcreteCommandFactory();
            var client = new ClientInvoker<User, UserCommand>();
            client.Dispatch(factory, new User { Id = 1, Name = "Devansh" },new UserCommand());*/
            Console.ReadKey();
        }
    }
}
