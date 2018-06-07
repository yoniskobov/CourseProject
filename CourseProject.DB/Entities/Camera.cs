using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseProject.DB.Entities
{
    public class Camera : BaseEntity
    {

        [Required, StringLength(20)]
        [Index(IsUnique = true)]
        
        public string ID { get; set;}

        [StringLength (20)]
        public String Name { get; set;}

        [StringLength(20)]
        public string Price { get; set;}

        [StringLength(20)]
        public string Specs { get; set;}




    }
}
