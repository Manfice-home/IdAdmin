//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Id.domen
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPhotoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserPhotoes()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public int Id { get; set; }
        public byte[] PhotoData { get; set; }
        public string PhotoType { get; set; }
        public string FileName { get; set; }
        public int PhotoSise { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
