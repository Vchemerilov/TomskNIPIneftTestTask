using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SectionData.Models;
using SectionData.Manager;

namespace SectionData.Controllers
{
    public class SectionManagerController : Controller, ISectionController
    {
        private IManager sectionManager = new SectionManager();

        public ActionResult getSectionsInfo()
        {
            return Json(sectionManager.getJsonStrings(), JsonRequestBehavior.AllowGet);
        }
      
        public ActionResult getSectionInfo(string sectionName)
        {
            Section section = sectionManager.getSectionInfo(sectionName);

            if (section != null)
                return Json(new { name = section.Name, city = section.City, location = section.Location }, JsonRequestBehavior.AllowGet);
            else
            {
                Response.StatusCode = 404;
                return new HttpNotFoundResult();
            }
        }
      
        public bool createSection(String sectionName, String name, String city, String location)
        {
            return sectionManager.createSectionInfo(sectionName, name, city, location);
        }
      
        public bool updateSection(String sectionName, String name, String city, String location)
        {
            return sectionManager.updateSectionInfo(sectionName, name, city, location);
        }
    }
}