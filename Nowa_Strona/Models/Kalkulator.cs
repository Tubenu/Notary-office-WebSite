namespace Nowa_Strona.Models
{
    public class Kalkulator
    {
        public CalculateResult Sprzedaz_lokalu_mieszkalnego(double cena)
        {
            var result = new CalculateResult();
            double taksa_notarialna = 0;
            double wniosek_wieczystoksiegowy = 200;
            double oplata_za_zlozenie_wniosku_KW = 200;
            double VAT = 0.23;
            if (cena <= 3000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = 100.ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + (double.Parse(result.TaksaNotarialna) * VAT)).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " + 23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();


            }
            else if (cena >= 3000 && cena <= 10000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 3000) * 0.03) + 100).ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " + 23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            else if (cena >= 10000 && cena <= 30000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 10000) * 0.02) + 310).ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " +23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            else if (cena >= 30000 && cena <= 60000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 30000) * 0.01) + 710).ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " +23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            else if (cena >= 60000 && cena <= 1000000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 60000) * 0.004) + 1010).ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " +23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            else if (cena >= 1000000 && cena <= 2000000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 1000000) * 0.002) + 4770).ToString();
                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " +23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            else if (cena >= 2000000)
            {
                result.PCC = (cena * 0.02 + " zł").ToString();
                result.PCC2 = (cena * 0.02).ToString();
                result.TaksaNotarialna = (((cena - 2000000) * 0.0025) + 6770).ToString();
                if (taksa_notarialna > 10000)
                {
                    result.TaksaNotarialna = 10000.ToString();
                }

                result.TaksaVAT = (double.Parse(result.TaksaNotarialna) + double.Parse(result.TaksaNotarialna) * VAT).ToString();
                result.TaksaResult = (result.TaksaVAT + " zł " + "(" + result.TaksaNotarialna + " +23% VAT)").ToString();
                result.KWVAT = (oplata_za_zlozenie_wniosku_KW * VAT).ToString();
                result.Suma = (double.Parse(result.KWVAT) + oplata_za_zlozenie_wniosku_KW).ToString();
                result.WniosekWieczystoksiegowy = wniosek_wieczystoksiegowy + " zł".ToString();
                result.OplataWniosekWieczystoksiegowy = result.Suma + " zł (" + oplata_za_zlozenie_wniosku_KW + " + 23% VAT)";
                result.KwotaKoncowa = (double.Parse(result.PCC2) + double.Parse(result.TaksaVAT) + wniosek_wieczystoksiegowy + double.Parse(result.Suma) + " zł").ToString();

            }
            return result;
        }

    }
}
