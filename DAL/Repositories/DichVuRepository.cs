using DAL.EntityFramework;
using QLPT.HUMG.DAL.Interfaces;
using QLPT.HUMG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DichVuRepository : IDichVuRepository
    {
        private QuanLyPhongTroEntities db;
        public DichVuRepository()
        {
            db = new QuanLyPhongTroEntities();
        }
        public long Count()
        {
            return db.DichVus.Count();
        }

        public void Create(DichVu obj)
        {
            db.DichVus.Add(obj);
            db.SaveChanges();
        }

        public void Delete(object Id)
        {
            DichVu obj = db.DichVus.Find(Id);
            db.DichVus.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<DichVu> GetAll()
        {
            return db.DichVus;
        }

        public DichVu GetById(object Id)
        {
            return db.DichVus.Find(Id);
        }

        public void Update(DichVu obj)
        {
            db.DichVus.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
