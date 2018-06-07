using DesignPatterns.Patterns.Factory.Entities.Bases;
using DesignPatterns.Patterns.Factory.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    public static class Factory //Design Pattern : Simple Factory
    {
        private static Dictionary<string, CustomerBase> typesDict;

        static Factory()
        {
            //Desing Pattern : Eager Loading, RIP (Replace If with Polymorphism)
            typesDict = new Dictionary<string, CustomerBase>()
            {
                { "Customer", new Customer() },
                { "Lead", new Lead() },
            };
        }
        public static CustomerBase Create(string entityName)
        {
            if (typesDict == null) throw new Exception("Dictionary failed to load");

            #region Design Pattern : Lazy Loading

            //var cust = new Lazy<Dictionary<string, CustomerBase>> (() =>
            //    {
            //        typesDict = new Dictionary<string, CustomerBase>();
            //        typesDict.Add("Customer", new Customer());
            //        typesDict.Add("Lead", new Lead());
            //        return typesDict;
            //    });

            #endregion

            foreach (var item in typesDict /*cust.Value*/ )
            {
                if (entityName.ToLower() == item.Key.ToLower()) return item.Value;
            }

            throw new Exception("Undefined Customer Type");
        }
    }
}
