using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DB.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Location : BaseEntity
    {
        [Required, StringLength(20)]
        [Index(IsUnique = true)]

        public string CityName { get; set; }

        [StringLength(20)]
        public string StreetName { get; set; }
    }
}
