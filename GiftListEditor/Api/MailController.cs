using GiftListEditor.BLL.Enums;
using GiftListEditor.BLL.Models;
using GiftListEditor.DAL.DTO;
using GiftListEditor.DAL.Repositories;
using PDCore.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace GiftListEditor.Api
{
    public class MailController : ApiController
    {
        private readonly IMailRepository mailRepository;

        public MailController(IMailRepository mailRepository)
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

        [ResponseType(typeof(MailDtos))]
        public async Task<IHttpActionResult> Get(Folder folder)
        {
            MailDtos mails = await mailRepository.GetDtoAsync(m => m.Folder == folder);

            return Ok(mails);
        }
    }
}