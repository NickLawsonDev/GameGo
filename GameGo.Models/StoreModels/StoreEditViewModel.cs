using System.ComponentModel.DataAnnotations;

namespace GameGo.Models.StoreModels
{
    public class StoreEditViewModel
    {
        public int StoreId { get; set; }

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