using GiftListEditor.BLL.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.BLL.Models
{
    [Table("Mail", Schema = "dbo")]
    public class Mail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Folder")]
        public Folder Folder { get; set; }

        [Required]
        [Display(Name = "From")]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} must be greater than {2} characters and less than {1} characters,")]
        public string From { get; set; }

        [Required]
        [Display(Name = "To")]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} must be greater than {2} characters and less than {1} characters,")]
        public string To { get; set; }

        [Required]
        [Display(Name = "Subject")]
        [DataType(DataType.Text)]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "{0} must be greater than {2} characters and less than {1} characters,")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset Date { get; set; }

        [Required]
        [Display(Name = "MessageContent")]
        [DataType(DataType.Html)]
        [MaxLength(2500)]
        public string MessageContent { get; set; }
    }
}
