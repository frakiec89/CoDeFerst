using System.ComponentModel.DataAnnotations;

namespace ConsoleApp62.DB.Model
{
    public class TypeCar
    {  

        [Key]
        public int TypeCarId { get; set; }
        public string Name { get; set; }
       
    }
}