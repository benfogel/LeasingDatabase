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
    
    public partial class User
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.SystemGroups = new HashSet<SystemGroup>();
            this.Location = new Location();
        }
    
        public int Id { get; set; }
        public string GID { get; set; }
        public string Phone { get; set; }
    
        public Location Location { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SystemGroup> SystemGroups { get; set; }
    }
}
