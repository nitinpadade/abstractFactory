using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLayer.Client
{
    public interface ICommandHandler
    {
        TObj Dispatch<TCls, TObj>(TObj cmdObj)
           where TCls : class
           where TObj : class;
    }
}
