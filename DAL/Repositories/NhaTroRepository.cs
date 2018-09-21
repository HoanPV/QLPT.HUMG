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
    public class NhaTroRepository:INhaTroRepository
    {
        private QuanLyPhongTroEntities db;
        public NhaTroRepository()
        {
            db = new QuanLyPhongTroEntities();
        }
        public long Count()
        {
            return db.NhaTroes.Count();
        }

        public void Create(NhaTro obj)
        {
            db.NhaTroes.Add(obj);
            db.SaveChanges();
        }

        public void Delete(object Id)
        {
            NhaTro obj = db.NhaTroes.Find(Id);
            db.NhaTroes.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<NhaTro> GetAll()
        {
            return db.NhaTroes;
        }

        public NhaTro GetById(object Id)
        {
            return db.NhaTroes.Find(Id);
        }

        public void Update(NhaTro obj)
        {
            db.NhaTroes.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
