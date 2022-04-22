//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WindowsForms_lab_6_v1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Portfolios = new HashSet<Portfolio>();
        }
    
        public int ORD_ID { get; set; }
        public Nullable<int> ORD_AC_Account_ID { get; set; }
        public Nullable<int> ORD_ST_ID { get; set; }
        public string ORD_Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] ORD_Picture { get; set; }
        public string ORD_Description { get; set; }
        public int ORD_Cost { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Status Status { get; set; }
        public virtual OrdersInProgress OrdersInProgress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
