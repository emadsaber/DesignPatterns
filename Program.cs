using DesignPatterns.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_Singleton();


            #region Wait
            Console.ReadKey();
            #endregion
        }

        public static void Test_Singleton()
        {
            #region Logs
            Console.WriteLine("---------Singleton tests started---------\n"); 
            #endregion
            Logger.Instance.Log("I am a singleton instance");
            #region Logs
            Console.WriteLine("\n---------Singleton tests finished---------\n"); 
            #endregion
        }
    }
}
