using System;

namespace AbstractLayer.Factory
{
    public class ConcreteCommandFactory : CommandFactory
    {
        public override ICommand<TObj> CreateFactory<TObj, TCls>()
        {
            return (ICommand<TObj>)Activator.CreateInstance(typeof(TCls));
        }
    }
}
