using GiftListEditor.BLL.Models;
using GiftListEditor.DAL.DTO;
using GiftListEditor.DAL.Lazy.Proxies;
using PDCore.Extensions;
using PDCore.Interfaces;
using PDCoreNew.Context.IContext;
using PDCoreNew.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.DAL.Repositories
{
    public class MailRepository : SqlRepositoryEntityFrameworkDisconnected<Mail>, IMailRepository
    {
        public MailRepository(IEntityFrameworkDbContext ctx, ILogger logger) : base(ctx, logger)
        {
        }

        public Task<List<MailDto>> GetDtoAsync(Expression<Func<Mail, bool>> predicate)
        {
            return base.FindBy(predicate, m =>
                               new MailDto
                               {
                                   Date = m.Date,
                                   Folder = m.Folder,
                                   From = m.From,
                                   Id = m.Id,
                                   Subject = m.Subject,
                                   To = m.To
                               })
                               .ToListAsync();
        }
    }
}
