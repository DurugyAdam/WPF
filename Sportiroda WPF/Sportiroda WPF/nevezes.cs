//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sportiroda_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class nevezes
    {
        public int nevezes_id { get; set; }
        public Nullable<int> verseny_id { get; set; }
        public Nullable<int> versenyzo_id { get; set; }
    
        public virtual verseny verseny { get; set; }
        public virtual versenyzo versenyzo { get; set; }
    }
}
