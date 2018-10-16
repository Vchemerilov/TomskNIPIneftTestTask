using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SectionData.Controllers
{
    public interface ISectionController : IController
    {
        ActionResult getSectionInfo(string sectionName);
        ActionResult getSectionsInfo();
        bool createSection(String sectionName, String name, String city, String location);
        bool updateSection(String sectionName, String name, String city, String location); 
    }
}