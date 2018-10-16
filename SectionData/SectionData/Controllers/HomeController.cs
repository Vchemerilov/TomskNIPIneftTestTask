using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SectionData.Models;
using SectionData.Manager;

namespace SectionData.Controllers
{
    [RoutePrefix("conference")]
    public class HomeController : Controller
    {
       private ISectionController sectionManagerController = new SectionManagerController();
           
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("info")]
        public ActionResult getSectionsInfo()
        {
            return sectionManagerController.getSectionsInfo();
        }

        [HttpGet]    
        [Route("{sectionName}/info")]
        public ActionResult getSectionInfo(string sectionName)
        {
            return sectionManagerController.getSectionInfo(sectionName);
        }
       
        [HttpPost]
        [Route("{sectionName}/info")]
        public bool createSection(String sectionName, String name, String city, String location)
        {
            return sectionManagerController.createSection(sectionName, name, city, location);
        }
       
       [HttpPut]
       [Route("{sectionName}/info")]      
       public bool updateSection(String sectionName, String name, String city, String location)
       {
            return sectionManagerController.updateSection(sectionName, name, city, location);
       }

    }
}