using DemoWebAPI.Models.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class WebAPIController : ApiController
    {
        DemoWebAPIDbContext db = new DemoWebAPIDbContext();
        // GET api/webapi
        public IEnumerable<Contact> GetAll()
        {
            return db.Contacts.ToList();
        }

        // GET api/webapi/5
        public Contact GetById(int id)
        {
            var con = db.Contacts.Find(id);
            if(con == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return con;
        }

        // POST api/webapi
        public IEnumerable<Contact> PostContact(Contact model)
        {
            db.Contacts.Add(model);
            db.SaveChanges();
            return db.Contacts.ToList();
        }

        // PUT api/webapi/5
        public IEnumerable<Contact> PutContact(int id, Contact model)
        {
            var con = db.Contacts.Single(p => p.Id == id);
            if(con.Id != model.Id)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            return db.Contacts.ToList();
           
        }

        // DELETE api/webapi/5
        public IEnumerable<Contact> DeleteContact(int id)
        {
            var con = db.Contacts.Single(p => p.Id == id);
            db.Contacts.Remove(con);
            db.SaveChanges();
            return db.Contacts.ToList();
        }
    }
}
