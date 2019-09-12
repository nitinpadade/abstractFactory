using AbstractLayer.Factory;

namespace AbstractLayer.Client
{
    public class CommandHandler : ICommandHandler
    {
        readonly CommandFactory _factory = null;
        public CommandHandler(CommandFactory factory)
        {
            _factory = factory;
        }

        public TObj Dispatch<TCls, TObj>(TObj cmdObj)
            where TCls : class
            where TObj : class
        {
            var _handler = _factory.CreateFactory<TObj, TCls>();
            return _handler.Execute(cmdObj);
        }

    }
}
