
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer
{
    public class Satis
    {
        DataAccessLayer.Satis _satis = new DataAccessLayer.Satis();
        public bool Kaydet(EntityLayer.Satis satis)
        {
            if (_satis.Kaydet(satis))
                return true;
            return false;
        }

    }
}
