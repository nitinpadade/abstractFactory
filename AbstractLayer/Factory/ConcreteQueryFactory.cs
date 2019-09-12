using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLayer.Factory
{
    public class ConcreteQueryFactory : QueryFactory
    {
        public override IQuery<TResult, TParameters> CreateFactory<TResult, TParameters, TCls>()
        {
            return (IQuery<TResult, TParameters>)Activator.CreateInstance(typeof(TCls));
        }
    }
}
