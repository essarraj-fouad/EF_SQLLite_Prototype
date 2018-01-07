using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQLLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Database.EnsureCreated();


                db.Groups.Add(new App.Entities.Group());
                db.SaveChanges();

                Console.Write(db.Groups.FirstOrDefault().ToString());
                Console.ReadKey();

            }



        }
    }
}
