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
    public class PhongRepository : IPhongRepository
    {
        private QuanLyPhongTroEntities db;
        public PhongRepository()
        {
            db = new QuanLyPhongTroEntities();
        }
        public long Count()
        {
            return db.Phongs.Count();
        }

        public void Create(Phong obj)
        {
            db.Phongs.Add(obj);
            db.SaveChanges();
        }

        public void Delete(object Id)
        {
            Phong obj = db.Phongs.Find(Id);
            db.Phongs.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Phong> GetAll()
        {
            return db.Phongs;
        }

        public Phong GetById(object Id)
        {
            return db.Phongs.Find(Id);
        }

        public void Update(Phong obj)
        {
            db.Phongs.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
