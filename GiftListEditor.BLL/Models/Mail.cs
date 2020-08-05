using GiftListEditor.BLL.Enums;
using PDCore.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GiftListEditor.BLL.Models
{
    [Table("Mail", Schema = "dbo")]
    [DataContract]
    public class Mail : IModificationHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id", ResourceType = typeof(Resources.Models.Mail))]
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Folder", ResourceType = typeof(Resources.Models.Mail))]
        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }

        [Required]
        [Display(Name = "From", ResourceType = typeof(Resources.Models.Mail))]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, MinimumLength = 5, ErrorMessageResourceName = "StringLength_GreaterAndLess", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataMember(Name = "from")]
        public string From { get; set; }

        [Required]
        [Display(Name = "To", ResourceType = typeof(Resources.Models.Mail))]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, MinimumLength = 5, ErrorMessageResourceName = "StringLength_GreaterAndLess", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataMember(Name = "to")]
        public string To { get; set; }

        [Required]
        [Display(Name = "Subject", ResourceType = typeof(Resources.Models.Mail))]
        [DataType(DataType.Text)]
        [StringLength(150, MinimumLength = 4, ErrorMessageResourceName = "StringLength_GreaterAndLess", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Date", ResourceType = typeof(Resources.Models.Mail))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataMember(Name = "date")]
        public DateTimeOffset Date { get; set; }

        [Required]
        [Display(Name = "MessageContent", ResourceType = typeof(Resources.Models.Mail))]
        [DataType(DataType.Html)]
        [MaxLength(2500)]
        [DataMember(Name = "messageContent")]
        public string MessageContent { get; set; }


        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public bool IsDirty { get; set; }
    }
}
