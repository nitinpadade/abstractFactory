using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLayer
{
    class AbstractEnum
    {
    }

    public enum CommandQueryStatus
    {
        Default = 0,
        Executed,
        Failed,
        Warning,
        AccessDenied
    }

}
