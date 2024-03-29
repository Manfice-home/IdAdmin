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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.GoodsImages = new HashSet<GoodsImages>();
            this.Prices = new HashSet<Prices>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Articul { get; set; }
        public bool IsService { get; set; }
        public string Warranty { get; set; }
        public Nullable<int> Brand_Id { get; set; }
        public Nullable<int> MesureUnit_Id { get; set; }
        public Nullable<int> Vendor_Id { get; set; }
        public Nullable<int> Categoy_Id { get; set; }
        public Nullable<int> MenuItem_Id { get; set; }
    
        public virtual Brands Brands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsImages> GoodsImages { get; set; }
        public virtual Menus Menus { get; set; }
        public virtual MesureUnits MesureUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prices> Prices { get; set; }
        public virtual ProductMenuItems ProductMenuItems { get; set; }
        public virtual Vendors Vendors { get; set; }
    }
}
