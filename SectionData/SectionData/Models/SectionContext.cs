using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SectionData.Models
{
    public class SectionContext : DbContext
    {
        public DbSet<Section> Sections { get; set; }
    }
}