using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models.DB
{
    public class DemoWebApiInstializer: DropCreateDatabaseIfModelChanges<DemoWebAPIDbContext>
    {
        /// <summary>
        /// Thêm mới dữ liệu vào Database
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DemoWebAPIDbContext context)
        {
            base.Seed(context);

            context.Contacts.Add(new Contact { Name = "Nguyễn Văn Tèo", Email = "teo@gmail.com" });
            context.Contacts.Add(new Contact { Name = "Lê văn Tí", Email = "ti@gmail.com" });
            context.Contacts.Add(new Contact { Name = "Ngô Thị Lượm", Email = "luom@gmail.com" });

            context.SaveChanges();
        }
    }
}