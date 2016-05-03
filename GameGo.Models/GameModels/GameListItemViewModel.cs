using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameGo.Models
{
    public class GameListItemViewModel
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

        [Display(Name = "ID")]
        public string GameId { get; set; }

        [Display(Name = "Title")]
        public string Name { get; set; }

        [Display(Name = "Rating")]
        public Rating GameRating { get; set; }

        [Display(Name = "Genres")]
        public ICollection<Genre> Genres { get; set; }

        #endregion
    }
}