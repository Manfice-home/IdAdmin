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
    
    public partial class GoodsImages
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }
        public string FileName { get; set; }
        public int ImageSize { get; set; }
        public Nullable<int> ProductOf_Id { get; set; }
    
        public virtual Products Products { get; set; }
    }
}