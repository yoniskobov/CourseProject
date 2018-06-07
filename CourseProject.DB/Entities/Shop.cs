using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DB.Entities
{
  public  class Shop : BaseEntity
    {
        [Required, Index(IsUnique = true), StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string StreetName { get; set; }

        [StringLength(10)]
        public string  WorkTime { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal OnlineOrder { get; set; }
        
    }
}
