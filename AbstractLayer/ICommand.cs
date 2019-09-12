using System;

namespace AbstractLayer
{
    public interface ICommand<T>
    {
        T Execute(T obj);
    }
}
