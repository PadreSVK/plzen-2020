using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySuperSettings
    {
        [Required]
        public string ServerUrl { get; set; }
        public string Test { get; set; }
    }
}
