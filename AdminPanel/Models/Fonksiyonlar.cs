using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Models
{
    public class Fonksiyonlar
    {

        public static void CacheYukle()
        {
            AdminPanelDBEntities db = new AdminPanelDBEntities();
            Sabitler.ModulList = db.tbl_Modul.ToList();
            Sabitler.DilListe = db.tbl_Dil.ToList();
            Sabitler.DilCeviriListe = db.tbl_DilCeviri.ToList();
        }


        public static List<tbl_Icerik> AltIcerikleriVer(List<tbl_Icerik> Liste, tbl_Icerik UstIcerik, bool isKendisiEklensinmi = true)
        {
            List<tbl_Icerik> sonuc = new List<tbl_Icerik>();

            if (isKendisiEklensinmi)
            {
                sonuc.Add(UstIcerik);
            }

            foreach (var item in Liste.Where(d => d.UstID == UstIcerik.ID))
            {
                sonuc.AddRange(AltIcerikleriVer(Liste, item, isKendisiEklensinmi));
            }

            return sonuc;

        }

        public static string Liste(List<SelectModel> data, string TurAdi = "", int UstKatID = 0)
        {

            UrlHelper u = new UrlHelper(HttpContext.Current.Request.RequestContext);
            if (!data.Any(d => d.UstID == UstKatID))
                return "";
            string sonuc = "<ul class='dd-list'>";
            foreach (var item in data.Where(d => d.UstID == UstKatID).OrderBy(d => d.SiraNo))
            {
                sonuc += "<li class='dd-item dd3-item' data-id='" + item.ID + "'><div class='dd-handle dd3-handle'></div><div class='dd3-content'><span class='listeMobil'>" + item.Name + "</span><span style='float:right; top:2px;right:2px;' class='hidden-print listeMobilright' >";

                sonuc += "<a class='btn btn-xs blue' href=' " + u.Action("Detay", TurAdi, new { ID = item.ID, area = "yonetim" }) + "'> Detay </a> " + "|";

                sonuc += " <a class='btn btn-xs green' href=' " + u.Action("Ekle", TurAdi, new { ID = item.ID, area = "yonetim" }) + "'> " + "Düzenle" + " </a>  | <a class='btn btn-xs red-mint' data-btn-ok-class='btn-success' data-btn-ok-label='Evet' data-btn-cancel-label='Hayır' data-btn-cancel-class='btn-danger' data-toggle='confirmation' data-placement='left' data-popout='true' data-title='Silmek istediğinizden eminmisiniz ? '> " + "Sil" + " </a>  ";

                sonuc += "</span></div>";

                sonuc += Liste(data.ToList(), TurAdi, item.ID);

                sonuc += "</li>";
            }
            return sonuc + "</ul>";
        }

    }
}