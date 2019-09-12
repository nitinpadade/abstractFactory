using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLayer.Factory
{
    public abstract class CommandFactory
    {
        public abstract ICommand<TObj> CreateFactory<TObj, TCls>() 
            where TObj : class
             where TCls : class;
    }
}
