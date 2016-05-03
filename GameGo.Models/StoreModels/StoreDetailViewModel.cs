using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameGo.Models.StoreModels
{
    public class StoreDetailViewModel
    {
        [Required]
        public int StoreId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}