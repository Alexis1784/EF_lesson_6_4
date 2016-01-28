using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MobileContext db = new MobileContext())
            {
                db.Phones.Add(new Phone
                {
                    Name = "Samsung Galaxy S5",
                    Info = new PhoneInfo { Company = "Samsung", Price = 17000 }
                });
                db.Phones.Add(new Phone
                {
                    Name = "Nokia Lumia 930",
                    Info = new PhoneInfo { Company = "Nokia", Price = 15000 }
                });
                db.SaveChanges();
                foreach (Phone p in db.Phones)
                    Console.WriteLine("{0} - {1}", p.Name, p.Info.Price);
            }
            Console.ReadLine();
        }
    }
}
