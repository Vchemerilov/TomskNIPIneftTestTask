using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SectionData.Models;


namespace SectionData.Manager
{
    public interface IManager
    {
        Section getSectionInfo(String sectionName);
        List<Object> getJsonStrings();
        bool createSectionInfo(String sectionName, String name, String city, String location);
        bool updateSectionInfo(String sectionName, String name, String city, String location);    
    }
}