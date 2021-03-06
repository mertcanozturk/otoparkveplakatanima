﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Abone
    {
        DataAccessLayer.Abone aboneControl = new DataAccessLayer.Abone();
        public List<EntityLayer.Abone> Listele()
        {
            List<EntityLayer.Abone> aboneList = new List<EntityLayer.Abone>();
            EntityLayer.Abone abone = new EntityLayer.Abone();
            DataTable dt = aboneControl.Listele();
            foreach (DataRow dr in dt.Rows)
            {
                abone.Adi = dr["ADI"].ToString();
                abone.Soyadi = dr["SOYADI"].ToString();
                abone.Adres = dr["ADRES"].ToString();
                abone.Telefon = dr["TELEFON"].ToString();
                abone.Plaka = dr["PLAKA"].ToString();
                abone.AracTipAdi = dr["ARACTIPADI"].ToString();
                abone.GirisTarihi = Convert.ToDateTime(dr["GIRISTARIH"]);
                abone.AbonelikAdi = dr["ABONELIKADI"].ToString();
                abone.BitisTarihi = Convert.ToDateTime(dr["BITISTARIHI"]);
                abone.Fiyat = Convert.ToDecimal(dr["FIYAT"]);
                abone.Id = Convert.ToInt32(dr["ID"]);
                aboneList.Add(abone);
            }
            return aboneList;
        }
        public List<EntityLayer.Abone> Listele(string Plaka,string Adi,string Soyadi,string aracTipi,string Telefon)
        {
            List<EntityLayer.Abone> aboneList = new List<EntityLayer.Abone>();
            EntityLayer.Abone abone = new EntityLayer.Abone();
            DataTable dt = aboneControl.Listele(Plaka,Adi,Soyadi,aracTipi,Telefon);
            foreach (DataRow dr in dt.Rows)
            {
                abone = new EntityLayer.Abone();
                abone.Adi = dr["ADI"].ToString();
                abone.Soyadi = dr["SOYADI"].ToString();
                abone.Adres = dr["ADRES"].ToString();
                abone.Telefon = dr["TELEFON"].ToString();
                abone.Plaka = dr["PLAKA"].ToString();
                abone.AracTipAdi = dr["ARACTIPADI"].ToString();
                abone.GirisTarihi = Convert.ToDateTime(dr["GIRISTARIH"]);
                abone.AbonelikAdi = dr["ABONELIKADI"].ToString();
                abone.BitisTarihi = Convert.ToDateTime(dr["BITISTARIHI"]);
                abone.Fiyat = Convert.ToDecimal(dr["FIYAT"]);
                abone.Id = Convert.ToInt32(dr["ID"]);
                aboneList.Add(abone);
            }
            return aboneList;
        }
        public bool Kaydet(EntityLayer.Abone abone)
        {
            DataTable dt = new DataTable();
            try
            {
                if (aboneControl.AboneEkle(abone))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AboneTipSil(int Id)
        {
            if (aboneControl.AboneTipSil(Id))
                return true;
            else
                return false;
        }
        public bool AboneTipGuncelle(EntityLayer.AboneTip aboneTip)
        {
            if (aboneControl.AboneTipGuncelle(aboneTip))
                return true;
            else
                return false;
        }
        public bool AboneTipKaydet(EntityLayer.AboneTip aboneTip)
        {
            if (aboneControl.AboneTipEkle(aboneTip))
                return true;
            else
                return false;
        }
        public List<EntityLayer.AboneTip> AboneTipListesiGetir()
        {
            return aboneControl.AboneTipListesiGetir();
        }
        public int AbonelikTipiIdGetir(string AbonelikAdi)
        {
            return aboneControl.AbonelikTipiIdGetir(AbonelikAdi);
        }
        public EntityLayer.AboneTip aboneTipGetir(string aboneTipAdi)
        {
            return aboneControl.AboneTipGetir(aboneTipAdi);
        }
        public List<EntityLayer.AboneTip> aboneTipGetir()
        {
           return aboneControl.AboneTipListesiGetir();
        }
    }
}
