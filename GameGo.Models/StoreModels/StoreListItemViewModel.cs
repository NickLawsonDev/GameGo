using GameGo.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameGo.Models
{
    public class StoreListItemViewModel
    {
        [Display(Name = "ID")]
        public int StoreId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }
    }
}
