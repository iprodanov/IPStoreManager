//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPStoreManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public Sale()
        {
            this.SaleItems = new HashSet<SaleItem>();
        }
    
        public int SaleID { get; set; }
        public int UserID { get; set; }
        public System.DateTime SaleTimeStamp { get; set; }
    
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        public virtual User User { get; set; }
    }
}
