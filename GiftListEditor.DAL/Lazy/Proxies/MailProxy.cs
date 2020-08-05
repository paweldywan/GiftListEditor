using GiftListEditor.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.DAL.Lazy.Proxies
{
    public class MailProxy : Mail
    {
        public MailProxy(Mail mail)
        {
            Id = mail.Id;
            Folder = mail.Folder;
            From = mail.From;
            To = mail.To;
            Subject = "dupaaa";
            Date = mail.Date;
        }

        public MailProxy()
        {

        }
    }
}
