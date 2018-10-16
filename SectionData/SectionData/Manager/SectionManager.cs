using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using SectionData.Models;

namespace SectionData.Manager
{
    public class SectionManager : IManager
    {
        private SectionContext db = new SectionContext();

        public Section getSectionInfo(String sectionName)
        {
          return db.Sections.FirstOrDefault(section => section.SectionName == sectionName);
        }

        private Object getJsonString(Section section)
        {
          return new { section = section.SectionName, info = new { name = section.Name, city = section.City, location = section.Location } };
        }

        public List<Object> getJsonStrings() 
        {
          return db.Sections.ToList().Select(e => (getJsonString(e))).ToList();
        }

        public bool createSectionInfo(String sectionName, String name, String city, String location)
        {
            if (db.Sections.FirstOrDefault(e => e.SectionName == sectionName) == null)
            {
                db.Sections.Add(new Section { SectionName = sectionName, Name = name, City = city, Location = location });
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool updateSectionInfo(String sectionName, String name, String city, String location)
        {
            var section = db.Sections.FirstOrDefault(e => e.SectionName == sectionName);

            if (section != null)
            {
                section.Name = name;
                section.City = city;
                section.Location = location;

                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}