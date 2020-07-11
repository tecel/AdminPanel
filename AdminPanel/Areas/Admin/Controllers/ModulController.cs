using AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Areas.Admin.Controllers
{
    public class ModulController : Controller
    {
        AdminPanelDBEntities db = new AdminPanelDBEntities();
        // GET: Admin/Modul
        public ActionResult Index(string Arama="")
        {

            List<tbl_Modul> mdListe = Sabitler.ModulList;

            if(!string.IsNullOrEmpty(Arama))            
                mdListe = mdListe.Where(d => d.Adi.ToLower().Contains(Arama.ToLower())).ToList();
            
         

      
            return View(mdListe);
        }
 
        public ActionResult Ekle(int ID=0)
        {
           
            tbl_Modul md = db.tbl_Modul.FirstOrDefault(d => d.ID == ID) ;
            if(md==null)
            {
                md = new tbl_Modul();
            }
             
            return View(md);
        }

        [HttpPost]
        public ActionResult Ekle(tbl_Modul mdPost)
        {
            

            tbl_Modul md = db.tbl_Modul.FirstOrDefault(d => d.ID == mdPost.ID);

            if (md == null)
            {
                md = new tbl_Modul();
            }

            md.Adi = mdPost.Adi;
            
            md.isAktif = mdPost.isAktif;
            md.SiraNo = mdPost.SiraNo;
            md.Limit = mdPost.Limit;
            if(mdPost.ID==0)
            {
                md.EklenmeTarihi = DateTime.Now;
                db.tbl_Modul.Add(md);
            }

            try
            {
                db.SaveChanges();
                Sabitler.ModulList = db.tbl_Modul.ToList();
            }
            catch (Exception ex)
            {

                
            }



            return RedirectToAction("Index");
        }


        public ActionResult Sil(int ID )
        {
            
            tbl_Modul md = db.tbl_Modul.FirstOrDefault(d => d.ID == ID);
            if (md == null)
            {
                //Uyari mesajı
                return RedirectToAction("Index");
            }

            db.tbl_Modul.Remove(md);

            try
            {
                db.SaveChanges();
                Sabitler.ModulList = db.tbl_Modul.ToList();
            }
            catch (Exception ex) 
            {
 
            }
            return RedirectToAction("Index");
        }
    }
}