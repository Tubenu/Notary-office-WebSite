﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nowa_Strona.Models
{
    public class AdminLogin
    {
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Pass { get; set; }

    }
}