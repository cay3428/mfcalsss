using System;
using System.Collections.Generic;
using System.Text;

namespace busiziii.CCS
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
