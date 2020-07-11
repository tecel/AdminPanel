using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class SelectModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
     
        public int UstID { get; set; }

        public int SiraNo { get; set; }
    
        public bool isDuzenleSil { get; set; }


    }
}