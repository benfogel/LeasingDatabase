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
    
    public partial class VendorRate
    {
        public VendorRate()
        {
            this.Charges = new HashSet<Charge>();
        }
    
        public int Id { get; set; }
        public int Term { get; set; }
        public System.DateTime BeginDate { get; set; }
        public int TypeId { get; set; }
        public decimal Rate { get; set; }
    
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual Type Type { get; set; }
    }
}
