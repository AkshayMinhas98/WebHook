using System;
using System.Collections.Generic;

namespace WebHookDemoProject.Interface
{
    public interface ILogger
    {
        void Log(string payLoad);
        void Error();
    }

   
}
