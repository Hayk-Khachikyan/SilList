
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

namespace SO.SilList.Manager.Models.ValueObjects
{
     
    [Table("Rating", Schema = "data" )]
    [Serializable]
    public partial class RatingVo
    {
    		
    	[DisplayName("rating Id")]
    	[Key]
        public System.Guid ratingId { get; set; }
    		
    	[DisplayName("rating1")]
        public Nullable<int> rating1 { get; set; }
    		
    	[DisplayName("review")]
    	[StringLength(50)]
        public string review { get; set; }
    		
    	[DisplayName("member Id")]
        public Nullable<int> memberId { get; set; }
    		
    	[DisplayName("created")]
    	[Required]
        public System.DateTime created { get; set; }
    		
    	[DisplayName("modified")]
    	[Required]
        public System.DateTime modified { get; set; }
    		
    	[DisplayName("created By")]
        public Nullable<int> createdBy { get; set; }
    		
    	[DisplayName("modified By")]
        public Nullable<int> modifiedBy { get; set; }
    		
    	[DisplayName("is Active")]
        public Nullable<bool> isActive { get; set; }


        // [ForeignKey("foreignKeyname")]
        // public virtual SiteVo site { get; set; }

    	public RatingVo(){
    			
    	 this.ratingId = Guid.NewGuid();
    	
    	 this.isActive = true;
    	}
    }
}