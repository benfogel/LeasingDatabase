//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aulease.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tax
    {
        public Tax()
        {
            this.Charges = new HashSet<Charge>();
        }
    
        public int Id { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual ICollection<Charge> Charges { get; set; }
    }
}
