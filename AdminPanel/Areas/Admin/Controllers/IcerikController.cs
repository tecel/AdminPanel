using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
namespace AdminPanel.Areas.Admin.Controllers
{
    
    public class IcerikController : Controller
    {
        AdminPanelDBEntities db = new AdminPanelDBEntities();
        // GET: Admin/Icerik
        public ActionResult Index(int ModulID)
        {
            tbl_Modul md = Sabitler.ModulList.FirstOrDefault(d => d.ID == ModulID);

            ViewBag.Modul = md;

            List<tbl_Icerik> icList = db.tbl_Icerik.Where(d => d.ModulID == ModulID && d.DilID == Sabitler.GECERLI_DIL).ToList();

            return View(icList);
        }
        public ActionResult Ekle(int ID=0,int ModulID=0)
        {
            tbl_Icerik ic = db.tbl_Icerik.FirstOrDefault(d => d.ID == ID && d.DilID == Sabitler.GECERLI_DIL);

            if(ic==null)
            {
                ic = new tbl_Icerik();
                ic.ModulID = ModulID;
            }        
      
            

            return View(ic);
        }
        [HttpPost]
        public ActionResult Ekle(tbl_Icerik icPost)
        {

            tbl_Icerik ic = db.tbl_Icerik.FirstOrDefault(d => d.ID == icPost.ID && d.DilID == Sabitler.GECERLI_DIL);

            if(ic==null)
            {
                ic = new tbl_Icerik();
            }

            ic.Baslik = icPost.Baslik;
            ic.Ozet = icPost.Ozet;
            ic.Icerik = icPost.Icerik;
            ic.ModulID = icPost.ModulID;
            ic.isAktif = icPost.isAktif;
            ic.Link = icPost.Link;
            ic.Keyword = icPost.Keyword;
            ic.Description = icPost.Description;
            ic.DilID = Sabitler.GECERLI_DIL;
            ic.AnaResimYolu = "";
            ic.UstID = icPost.UstID;
            
            if(ic.ID==0)
            {
              
                ic.EklenmeTarihi = DateTime.Now;
                ic.SiraNo = 0;
                db.tbl_Icerik.Add(ic);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            { 

            }


            return RedirectToAction("Index",new {ModulID=ic.ModulID });
        }
    }
}