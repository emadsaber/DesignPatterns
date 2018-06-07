using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    public class Logger
    {
        private static Logger _instance;
        public static Logger Instance { get { return _instance != null ? _instance : new Logger(); }  }
         
        private Logger() { }

        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
