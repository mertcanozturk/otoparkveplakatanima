using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    public class AracCikis
    {
        List<EntityLayer.Arac.AracTip> aracTips=new List<EntityLayer.Arac.AracTip>();
        BusinessLayer.Arac arac = new BusinessLayer.Arac();
        public decimal UcretHesapla(int AracTipNo,DateTime GirisZamani)
        {
            TimeSpan fark = DateTime.Now - GirisZamani;
            int saat = Convert.ToInt32(fark.TotalHours);
            aracTips = arac.AracTipGetir();
            foreach (var item in aracTips)
            {
                if (item.Id==AracTipNo)
                {
                    return item.Fiyat * saat;
                }
            }
            return 0;
        }
    }
}
