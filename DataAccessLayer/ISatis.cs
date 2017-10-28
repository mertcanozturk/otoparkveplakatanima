using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface ISatis
    {
        DataTable Listele(string a, string b,string c,string d, DateTime f ,DateTime e);
        bool Kaydet(EntityLayer.Satis satis);
        bool Sil(int Id);
        bool Guncelle(EntityLayer.Satis satis);


    }
}
