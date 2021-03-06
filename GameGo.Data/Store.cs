﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameGo.Data
{
    public class Store
    {

        [Key]
        public int StoreId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Name { get; set; }

        //[Required]
        //ICollection<Game> Games { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Website { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}