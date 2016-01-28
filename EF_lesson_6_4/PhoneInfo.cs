using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_4
{
    [ComplexType]
    public class PhoneInfo
    {
        public string Company { get; set; }
        public int Price { get; set; }
    }
}
