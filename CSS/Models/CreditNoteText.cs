//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CreditNoteText
    {
        public int CreditNoteTextId { get; set; }
        public Nullable<int> AgreementNumber { get; set; }
        public Nullable<int> VariantNumber { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string CreditNoteText1 { get; set; }
    
        public virtual Agreement Agreement { get; set; }
    }
}
