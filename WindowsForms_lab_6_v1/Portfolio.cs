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
    
    public partial class Portfolio
    {
        public int POR_ART_ID { get; set; }
        public Nullable<int> POR_ORD_ID { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Order Order { get; set; }
    }
}
