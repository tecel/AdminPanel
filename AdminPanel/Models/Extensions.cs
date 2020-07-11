using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public static class Extensions
    {
        public static string ToKelimeCevir(this string Kelime)
        {
            tbl_DilCeviri cvr = Sabitler.DilCeviriListe.FirstOrDefault(d => d.DilID == Sabitler.GECERLI_DIL && d.Name == Kelime);
            if (cvr == null)
                return Kelime;
             
            return cvr.Value;
        }

    }
}