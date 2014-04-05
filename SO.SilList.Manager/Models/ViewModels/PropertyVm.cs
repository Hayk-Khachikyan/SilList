﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.SilList.Manager.Models.ValueObjects;
using SO.Utility.Classes;


namespace SO.SilList.Manager.Models.ViewModels
{
    public class PropertyVm
    {
        public List<PropertyVo> result { get; set; }
        public string keyword { get; set; }
        //public string location { get; set; }
        public int? filter_cityTypeId { get; set; } 
        public int? zip { get; set; }

        public int? siteId { get; set; }
        public int? listingDate { get; set; } 
        public int? propertyTypeId { get; set; }
        public int? propertyListingTypeId { get; set; }
        public int? entryStatusTypeId { get; set; }
        public int? bedroomTypeId { get; set; }
        public int? bathroomTypeId { get; set; }
        public int? size { get; set; }
        public int? lotSize { get; set; }
        public int? startingPrice { get; set; }
        public int? endingPrice { get; set; }
        public int? acceptsSection8TypeId { get; set; }
        public int? isPetAllowedTypeId { get; set; }
        //public bool? entryStatusTypeId { get; set; }

        [DisplayName("isActive: ")]
        public bool? isActive { get; set; }
        public string submitButton { get; set; }
        public Paging paging;
        //*****
        public bool? showPendingOnly { get; set; } // for Entry Status Type 

        public PropertyVo property { get; set; }
        //public List<ImageCheckBoxInfo> imagesToRemove { get; set; }

        public PropertyVm()
        {
            property = new PropertyVo();
            this.result = new List<PropertyVo>();
            if (paging == null)
                paging = new Paging();
        }

        public PropertyVm(PropertyVo input)
        {
            property = input;
            this.result = new List<PropertyVo>();
            if (paging == null)
                paging = new Paging();
        }

    }
}

