using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nowa_Strona.Models.ViewModels
{
    public class EditorViewModel
    {
        [UIHint("tinymce_jquery_full"), AllowHtml]
        public string TextField { get; set; }
    }
}