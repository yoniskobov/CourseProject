using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseProject.Web.Models
{
    public class CamerasViewModel
    {
        [Required]
        public virtual Camera Camera { get; set;}

        [Required, StringLength(20)]
        [Index(IsUnique = true)]
        public string ID { get; set; }

        [StringLength(20)]
        public String Name { get; set; }

        [StringLength(20)]
        public string Price { get; set; }

        [StringLength(20)]
        public string Specs { get; set; }

        public CamerasViewModel(Camera c)
        {
            ID = c.ID;
            Name = c.Name;
            Price = c.Price;
            Specs = c.Specs;
        }
    }
}