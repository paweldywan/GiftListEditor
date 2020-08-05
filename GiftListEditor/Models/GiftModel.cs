using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftListEditor.Models
{
    public class GiftModel
    {
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "Title", ResourceType = typeof(Resources.Models.GiftModel))]
        public string Title { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "Price", ResourceType = typeof(Resources.Models.GiftModel))]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}