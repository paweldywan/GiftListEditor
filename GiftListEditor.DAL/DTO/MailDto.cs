using GiftListEditor.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GiftListEditor.DAL.DTO
{
    [XmlRoot("mails")]
    public class MailDtos
    {
        [XmlElement("mail")]
        public List<MailDto> Mails { get; set; }

        public static implicit operator MailDtos(List<MailDto> c) => new MailDtos { Mails = c };
    }

    [DataContract(Name = "mail")]
    public class MailDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }

        [DataMember(Name = "from")]
        public string From { get; set; }

        [DataMember(Name = "to")]
        public string To { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "date")]
        public DateTimeOffset Date { get; set; }
    }
}
