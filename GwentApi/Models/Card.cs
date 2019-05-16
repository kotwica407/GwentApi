using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GwentApi.Models
{
    public class Card
    {
        public int CardId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a card description")]
        public string Description { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Please enter a correct provision cost")]
        public int Provision { get; set; }

        [Required(ErrorMessage = "Please enter a card faction")]
        public string Faction { get; set; }

        [Range(1, 20, ErrorMessage = "Please enter a correct card's power")]
        public int Power { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Rarity { get; set; }

        [Required]
        public string Type { get; set; }

        public string Categories { get; set; }

        public string PrimaryCategory { get; set; }

        [Required]
        public string ArtUrl { get; set; }
    }
}
