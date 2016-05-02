using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameGo.Data
{
    public class Store
    {
        #region Properties

        [Key]
        public int StoreId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        ICollection<Game> Games { get; set; }

        [Required]
        public string Location { get; set; }

        #endregion
    }
}