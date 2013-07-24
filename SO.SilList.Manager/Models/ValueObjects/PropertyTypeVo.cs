﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
/*
namespace SO.SilList.CodeGeneration.DbContexts.SilList
    [Table("PropertyType", Schema = "app")]
    [Serializable]
{
    using System;
    using System.Collections.Generic;

    public partial class PropertyType
    {
        [DisplayName("propertyType Id")]
        [Key]
        public PropertyType()
        {
            this.Rentals = new HashSet<Rental>();
        }

        public int propertyTypeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime modified { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<bool> isActive { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace SO.SilList.CodeGeneration.DbContexts.SilList
{
    [Table("PropertyType", Schema = "app")]
    [Serializable]
    public partial class PropertyType
    {

        [DisplayName("PropertyType Id")]
        [Key]
        public System.Guid PropertyTypeId { get; set; }

   //     [DisplayName("site Id")]
   //     public Nullable<int> siteId { get; set; }

        [DisplayName("name")]
        [StringLength(250)]
        public string name { get; set; }

        [DisplayName("description")]
        [StringLength(250)]
        public string address { get; set; }


        //  [Association("Business_BusinessCategories", "businessId", "businessId", IsForeignKey = true)]
       // public List<BusinessCategories> businessCategories { get; set; }

        
         public PropertyTypeVo(){
    			
    		this.PropertyTyeId = Guid.NewGuid();
    	    this.isActive = true;
    	 }

    }
}
