//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeasingDatabaseMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Billing
    {
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> BegBillDate { get; set; }
        public Nullable<System.DateTime> EndBillDate { get; set; }
        public Nullable<decimal> MonthlyCharge { get; set; }
        public Nullable<int> Term { get; set; }
        public Nullable<int> igfTerm { get; set; }
        public string Fund { get; set; }
        public string Org { get; set; }
        public string Program { get; set; }
        public bool Transfer { get; set; }
        public bool Extend { get; set; }
        public bool PaidinFull { get; set; }
        public int RecordID { get; set; }
        public string ContractNumber { get; set; }
        public Nullable<decimal> igfRate { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> ChargedRate { get; set; }
        public Nullable<decimal> LeasingRate { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public string StatementName { get; set; }
        public Nullable<decimal> ComponentCost { get; set; }
        public Nullable<decimal> InsuranceCost { get; set; }
        public Nullable<decimal> WarrantyCost { get; set; }
    }
}