﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SO.SilList.Manager.Managers;
using SO.SilList.Manager.Models.ValueObjects;

namespace SO.SilList.Tests.Managers
{
    [TestClass]
    public class ListingTypeManagerTest
    {
        private ListingTypeManager listingTypeManager = new ListingTypeManager();

        [TestMethod]
        public void getAllTest()
        {

            var res = listingTypeManager.getAll(null);

            if (res != null)
            {
                Assert.IsTrue(true);
            }
            else Assert.IsTrue(false);
        }


        [TestMethod]
        public void insertDeleteTest()
        {
            var vo = new ListingTypeVo();
            vo.description = "description";
            vo.name = "good job";

            var result = listingTypeManager.insert(vo);
            var result2 = listingTypeManager.get(result.listingTypeId);

            listingTypeManager.delete(result.listingTypeId);

            var result3 = listingTypeManager.get(result.listingTypeId);

            if (result != null && result2 != null && result3 == null && result2.listingTypeId != null)
            {
                Assert.IsTrue(true);
            }
            else
                Assert.IsTrue(false);
        }
    }
}