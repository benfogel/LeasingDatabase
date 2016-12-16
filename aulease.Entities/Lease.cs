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
    
    public partial class Lease
    {
        public Lease()
        {
            this.Charges = new HashSet<Charge>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StatementName { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string ContractNumber { get; set; }
        public int DepartmentId { get; set; }
        public Nullable<decimal> MonthlyCharge { get; set; }
        public Nullable<int> OverheadId { get; set; }
        public int ComponentId { get; set; }
        public int SystemGroupId { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual Department Department { get; set; }
        public virtual Overhead Overhead { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual SystemGroup SystemGroup { get; set; }
    }
}