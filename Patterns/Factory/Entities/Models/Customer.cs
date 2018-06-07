using DesignPatterns.Patterns.Factory.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.Entities.Models
{
    public class Customer : CustomerBase
    {
        
        public override void Validate()
        {
            if (string.IsNullOrEmpty(this.Name)) throw new Exception("Name is required");
            if (string.IsNullOrEmpty(this.PhoneNumber)) throw new Exception("Phone Number is required");
            if (this.BillDate > DateTime.Now) throw new Exception("Bill date is required");
            if (this.BillAmount <= 0) throw new Exception("Bill amount is required");
        }
    }
}
