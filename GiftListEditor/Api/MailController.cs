using GiftListEditor.BLL.Enums;
using GiftListEditor.BLL.Models;
using PDCore.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace GiftListEditor.Api
{
    public class MailController : ApiController
    {
        private readonly ISqlRepositoryEntityFrameworkDisconnected<Mail> mailRepository;

        public MailController(ISqlRepositoryEntityFrameworkDisconnected<Mail> mailRepository)
        {
            this.mailRepository = mailRepository;
        }

        [ResponseType(typeof(Mail))]
        public async Task<IHttpActionResult> Get(int mailId)
        {
            var mail = await mailRepository.FindByIdAsync(mailId);

            if(mail == null)
            {
                return NotFound();
            }

            return Ok(mail);
        }

        [ResponseType(typeof(Mail))]
        public async Task<IHttpActionResult> Get(Folder folder)
        {
            var mail = await mailRepository.Find(m => m.Folder == folder).FirstOrDefaultAsync();

            if (mail == null)
            {
                return NotFound();
            }

            return Ok(mail);
        }
    }
}