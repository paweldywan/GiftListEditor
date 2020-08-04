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
            Database.SetInitializer(new WebmailDbInitializer());
        }

        public DbSet<Mail> Mails { get; set; }
    }
}
