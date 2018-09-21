using DAL.EntityFramework;
using QLPT.HUMG.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangRepository:IKhachHangRepository
    {
        private QuanLyPhongTroEntities db;
        public KhachHangRepository()
        {
            db = new QuanLyPhongTroEntities();
        }
        public long Count()
        {
            return db.KhachHangs.Count();
        }

        public void Create(KhachHang obj)
        {
            db.KhachHangs.Add(obj);
            db.SaveChanges();
        }

        public void Delete(object Id)
        {
            KhachHang obj = db.KhachHangs.Find(Id);
            db.KhachHangs.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return db.KhachHangs;
        }

        public KhachHang GetById(object Id)
        {
            return db.KhachHangs.Find(Id);
        }

        public void Update(KhachHang obj)
        {
            db.KhachHangs.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
