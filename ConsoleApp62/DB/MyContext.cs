using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62.DB
{
    public class MyContext : DbContext
    {
        string cs = "Server=192.168.10.134;Database=Test_Ahtyamov_IS_19_03;user=stud;password=stud;";


        public DbSet<Model.Car> Cars { get; set; }
        public DbSet<Model.TypeCar> TypeCars { get; set; }

        public MyContext()
        {

        }


        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptionsBuilder )
        {
            dbContextOptionsBuilder.UseSqlServer(cs);
        }
    }
}
