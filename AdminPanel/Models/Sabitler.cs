using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Sabitler
    {
        public static List<tbl_Modul> ModulList = new List<tbl_Modul>();

        public static List<tbl_Dil> DilListe = new List<tbl_Dil>();

        public static List<tbl_DilCeviri> DilCeviriListe = new List<tbl_DilCeviri>();
        public static int GECERLI_DIL
        {
            get
            {
                string kisa = (HttpContext.Current.Request.RequestContext.RouteData.Values["dil"] + "").ToLower();
                kisa = (kisa == "" ? "tr" : kisa);
                return DilListe.FirstOrDefault(d => d.KisaAd == kisa).ID;
            }
        }

        public static tbl_Dil GECERLI_DIL_FULL
        {
            get
            {
                string kisa = (HttpContext.Current.Request.RequestContext.RouteData.Values["dil"] + "").ToLower();
                kisa = (kisa == "" ? "tr" : kisa);
                return DilListe.FirstOrDefault(d => d.KisaAd == kisa);
            }
        }

    }
}