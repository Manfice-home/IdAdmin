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
    
    public partial class News
    {
        public int Id { get; set; }
        public System.DateTime NewsTime { get; set; }
        public byte[] Glyf { get; set; }
        public string ImageMimeType { get; set; }
        public string Title { get; set; }
        public string ShortDescr { get; set; }
        public string FullNewsBody { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public bool Published { get; set; }
    }
}
