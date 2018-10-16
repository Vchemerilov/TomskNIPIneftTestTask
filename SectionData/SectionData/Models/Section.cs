using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SectionData.Models
{
    public class Section
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
        public int Id { get; set; }

        public string SectionName { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

    }
}