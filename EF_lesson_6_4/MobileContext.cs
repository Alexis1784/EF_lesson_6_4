using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_4
{
    class MobileContext : DbContext 
    {
        public DbSet<Phone> Phones { get; set; }
        public MobileContext() : base("EF_lesson_6_4") { }
        // Альтернативный вариант применению атрибута  [ComplexType] для класса PhoneInfo
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.ComplexType<PhoneInfo>();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
