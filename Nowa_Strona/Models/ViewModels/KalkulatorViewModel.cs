using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nowa_Strona.Models.ViewModels
{
    public class KalkulatorViewModel
    {
        public string Cena { get; set; }
        public string ChoosedValue { get; set; }
        public CalculateResult Result { get; set; }
    }
}