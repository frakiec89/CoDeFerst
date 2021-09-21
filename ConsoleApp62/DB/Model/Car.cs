using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62.DB.Model
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Name { get; set; }


        public int TypeCarId { get; set; }
        public TypeCar TypeCar { get; set; } 
    }
}
