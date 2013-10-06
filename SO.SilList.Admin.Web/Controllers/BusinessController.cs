﻿using SO.SilList.Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Manager.Models.ViewModels;
using System.Web.Security;
using SO.SilList.Utility.Classes;

namespace SO.SilList.Admin.Web.Controllers
{
    public class BusinessController : Controller
    {
        private BusinessManager businessManager = new BusinessManager();

          
        public ActionResult Index(BusinessVm input=null,Paging paging = null)
        {
            var user = Membership.GetUser();
            input.paging = paging;
            if (input == null)input = new BusinessVm();
            
            if (this.ModelState.IsValid)
            {
                if (input.submitButton != null)
                    input.paging.pageNumber = 1;
                input = businessManager.search(input);
                return View(input);
            }
           
            return View();

        }
        public ActionResult Filter(BusinessVm input)
        {
            return PartialView("_Filter", input);
        }

         
        [HttpPost]
        public ActionResult Edit(Guid id, BusinessVo input)
        {

            if (this.ModelState.IsValid)
            {
                var res = businessManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Edit(Guid id)
        {
            var result = businessManager.get(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Create(BusinessVo input)
        {

            if (this.ModelState.IsValid)
            {

                var item = businessManager.insert(input);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Create()
        {
            var vo = new BusinessVo();
            return View(vo);
        }

        public ActionResult Details(Guid id)
        {
            //var idNew = new Guid("6ebe653d-0a10-44bf-bff6-84e1dbe6e36d");
            var result = businessManager.get(id);
            return PartialView(result);
        }

        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        public ActionResult Pagination(Paging input)
        {
            return PartialView("_Pagination", input);
        }
        

        public ActionResult Delete(Guid id)
        {
            businessManager.delete(id);
            return RedirectToAction("Index");
        }

      
    }
}
