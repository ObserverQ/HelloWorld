using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Empty2Foo.Models
{
    public class Person
    {
        [Required(ErrorMessage="姓名不能为空！")]
        public String Name { get; set; }
        [Required(ErrorMessage ="请输入密码！" )]
        public int Password { get; set; }
    }
}
