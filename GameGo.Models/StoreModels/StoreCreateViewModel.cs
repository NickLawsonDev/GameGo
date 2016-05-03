using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameGo.Models
{
    public class StoreCreateViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "The name must be longer than 2 characters long")]
        [StringLength(50, ErrorMessage = "The name must be shoter than 50 characters long")]
        public string Name { get; set; }

        public string Location { get; set; }
    
        public string Website { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}