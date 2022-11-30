using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int DailyPrice { get; set; }
        public int RentDate { get; set; } 
        public int BrandId { get; set; }   //  ONE TO MANY RELATION
        public virtual Brand Brand { get; set; }
        public int ModelId { get; set; }
        public ICollection<Model> Models { get; set; }  // MANY TO MANY RELATION
    }
}
