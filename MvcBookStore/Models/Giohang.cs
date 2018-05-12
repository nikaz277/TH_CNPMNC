using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBookStore.Models;
namespace MvcBookStore.Models
{
    public class Giohang
    {
        dbQLBansachDataContext db = new dbQLBansachDataContext();
        public int iMasach { get; set; }
        public string sTensach { get; set; }
        public string sAnhbia { get; set; }
        public double dDongia { get; set; }
        public int iSoluong { get; set; }
        public double dThanhtien
        {
            get
            {
                return iSoluong * dDongia;
            }
        }
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = db.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Hinhminhhoa;
            dDongia = double.Parse(sach.Dongia.ToString());
            iSoluong = 1;

        }
    }
}