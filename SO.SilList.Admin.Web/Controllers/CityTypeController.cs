using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using EntityFramework.Extensions;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Manager.DbContexts;
using SO.SilList.Manager.Managers;
using SO.SilList.Manager.Models.ViewModels;
using SO.Utility.Classes; 
using SO.Utility.Models.ViewModels;
using SO.Utility;
using SO.Utility.Helpers;
using SO.Utility.Extensions;

namespace  SO.SilList.Admin.Web.Controllers
{
    public class CityTypeController : Controller
    {
        private CityTypeManager cityTypeManager = new CityTypeManager();


		public ActionResult Index(SearchFilterVm input = null, Paging paging = null)
        {
            if (input == null) input = new SearchFilterVm();
            input.paging = paging;

            if (this.ModelState.IsValid)
            { 
                if (input.submitButton != null)
                    input.paging.pageNumber = 1;
                input = cityTypeManager.search(input);
                return View(input);
            }
            return View(input);
        }

		

        public FileResult Export(SearchFilterVm input = null)
        {

            if (this.ModelState.IsValid)
            {
                input.paging = null;
                input = cityTypeManager.search(input);
                var file = ImportExportHelper.exportToCsv(input.result);

                return File(file.FullName, "Application/octet-stream", file.Name);
            }

            return null;
        }
		 
	    #region CRUD

		public ActionResult List()
        {
            var results = cityTypeManager.getAll(null);
            return PartialView(results);
        }

        [HttpPost]
        public ActionResult Edit(int id, CityTypeVo input)
        {

            if (this.ModelState.IsValid)
            {
                var res = cityTypeManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View(input); 

        }
        public ActionResult Edit(int id)
        {
            var result = cityTypeManager.get(id);
            return View(result); 
        }

        [HttpPost]
        public ActionResult Create(CityTypeVo input)
        {

            if (this.ModelState.IsValid)
            {

                var item = cityTypeManager.insert(input);
                return RedirectToAction("Index");
            }


            return View(input);

        }

        public ActionResult Create()
        {
            var vo = new CityTypeVo();
            return View(vo);
        }

        public ActionResult Details(int id)
        {
            var result = cityTypeManager.get(id);
            return View(result);
        }

        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        public ActionResult Delete(int id)
        {
            cityTypeManager.delete(id);
            return RedirectToAction("Index");
        }

		#endregion
    }	 
        
    
}

