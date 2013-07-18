//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.LocalClub.Manager.Models.ValueObjects
{
    [Table("ClubEventMember", Schema = "data" )]
    [Serializable]
    public  class ClubEventMemberVo
    {
    	[DisplayName("club Event Member Id")]
    	[Required]
    	[Key]
        public Guid clubEventMemberId { get; set; }
    
    	[DisplayName("member Id")]
    	[Required]
        public Guid memberId { get; set; }
    
    	[DisplayName("club Event Id")]
    	[Required]
        public Guid clubEventId { get; set; }
    
    	[DisplayName("is Going")]
        public Nullable<byte> isGoing { get; set; }
    
    	[DisplayName("comment")]
        public string comment { get; set; }
    
    	[DisplayName("modified")]
    	[Required]
        public DateTime modified { get; set; }
    
    	[DisplayName("created")]
    	[Required]
        public DateTime created { get; set; }
    
    
        [ForeignKey("clubEventId")]
        public ClubEventVo clubEvent { get; set; }
       
        [ForeignKey("memberId")]
        public MemberVo member { get; set; }
       
    }
    
}
