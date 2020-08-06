using GiftListEditor.BLL.Models;
using PDCoreNew.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.DAL
{
    public class WebmailContext : MainDbContext
    {
        public WebmailContext() : base("WebmailContext")
        {
            //Database.SetInitializer(new WebmailDbInitializer());
            Database.SetInitializer(new NullDatabaseInitializer<WebmailContext>());
        }

        public DbSet<Mail> Mails { get; set; }

        public DbSet<BLL.Models.Task> Tasks { get; set; }
    }
}
