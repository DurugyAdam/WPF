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
    
    public partial class versenyzo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public versenyzo()
        {
            this.nevezes = new HashSet<nevezes>();
        }
    
        public int versenyzo_id { get; set; }
        public string nev { get; set; }
        public Nullable<System.DateTime> szuldatum { get; set; }
        public Nullable<int> nem { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nevezes> nevezes { get; set; }
    }
}
