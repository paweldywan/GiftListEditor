using PDCore.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GiftListEditor.BLL.Models
{
    [Table("Task", Schema = "dbo")]
    [DataContract(Name = "task")]
    public class Task : IModificationHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id", ResourceType = typeof(Resources.Models.Task))]
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [Display(Name = "Title", ResourceType = typeof(Resources.Models.Task))]
        [DataType(DataType.Text)]
        [StringLength(150, MinimumLength = 4, ErrorMessageResourceName = "StringLength_GreaterAndLess", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [Display(Name = "IsDone", ResourceType = typeof(Resources.Models.Task))]
        [DataMember(Name = "isDone")]
        public bool IsDone { get; set; }


        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public bool IsDirty { get; set; }
    }
}
