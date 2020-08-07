using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftListEditor.Models
{
    public class Friend
    {
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Common))]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "IsOnTwitter", ResourceType = typeof(Resources.Home.Demo))]
        public bool IsOnTwitter { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "TwitterName", ResourceType = typeof(Resources.Home.Demo))]
        [DataType(DataType.Text)]
        public string TwitterName { get; set; }
    }
}