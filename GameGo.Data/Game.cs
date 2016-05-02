using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameGo.Data
{
    public class Game
    {
        #region Enums
        public enum Genre
        {
            ACTION = 0,
            PLATFORMER,
            SHOOTER,
            FIGHTING,
            STEALTH,
            SURVIVAL,
            HORROR
        }

        public enum Rating
        {
            EARLYCHILDHOOD = 0,
            EVERYONE,
            EVERYONE10PLUS,
            TEEN,
            MATURE,
            ADULTSONLY18PLUS
        }
        #endregion

        #region Properties
        [Key]
        [ForeignKey("Store")]
        public int GameId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<Genre> Genres { get; set; }

        [Required]
        public Rating GameRating { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Earnings { get; set; }

        #endregion
    }
}