using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nowa_Strona.Models
{
    public class Mail
    {
        [DataType(DataType.EmailAddress)]      
        public string Do { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Od { get; set; }
        [Required]
        public string Tytul { get; set; }
        [Required]
        public string Temat { get; set; }


    }
}