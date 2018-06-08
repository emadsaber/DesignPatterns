using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.Patterns.Stategy;
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
            Test_Factory();
            Test_Strategy();
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

        public static void Test_Factory()
        {
            #region Logs
            Console.WriteLine("---------Factory tests started---------\n");
            #endregion

            var c = Factory.Create("customer");
            var c2 = Factory.Create("lEad");

            Console.WriteLine($"{c.GetType().Name} is created");
            Console.WriteLine($"{c2.GetType().Name} is created");

            #region Logs
            Console.WriteLine("\n---------Factory tests finished---------\n");
            #endregion
        }

        public static void Test_Strategy()
        {
            #region Logs
            Console.WriteLine("---------Strategy tests started---------\n");
            #endregion

            var twitter = new Twitter();
            var chicken = new Chicken();

            Console.WriteLine($"Twitter says: {twitter.FlyBehaviour.StartFlying()}");
            Console.WriteLine($"Chicken says: {chicken.FlyBehaviour.StartFlying()}");

            #region Logs
            Console.WriteLine("\n---------Strategy tests finished---------\n");
            #endregion
        }

    }
}
