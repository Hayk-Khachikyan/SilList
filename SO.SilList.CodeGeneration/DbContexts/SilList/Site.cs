//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SO.SilList.CodeGeneration.DbContexts.SilList
{
    using System;
    using System.Collections.Generic;
    
    public partial class Site
    {
        public Site()
        {
            this.Businesses = new HashSet<Business>();
        }
    
        public int siteId { get; set; }
        public string name { get; set; }
        public string domain { get; set; }
    
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
