using System;
using System.IO;
using WebHookDemoProject.Interface;

namespace WebHookDemoProject.LogClasses
{
    public class FileLogger : ILogger
    {
        const string File_Path = @"E:\WebHookLog.txt";
        public void Error()
        {
            throw new NotImplementedException();
        }

        public void Log(string payLoad)
        {
            if (!File.Exists(File_Path))
            {
                throw new NotImplementedException();
            }
            var time = DateTime.Now;
            using (StreamWriter file = new StreamWriter(File_Path, true))
            {
                file.WriteLine(time + " " + payLoad);
            }

        }
    }
}