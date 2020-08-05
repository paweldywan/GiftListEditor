using GiftListEditor.BLL.Models;
using GiftListEditor.DAL.DTO;
using PDCore.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GiftListEditor.DAL.Repositories
{
    public interface IMailRepository : ISqlRepositoryEntityFrameworkDisconnected<Mail>
    {
        Task<List<MailDto>> GetDtoAsync(Expression<Func<Mail, bool>> predicate);
    }
}