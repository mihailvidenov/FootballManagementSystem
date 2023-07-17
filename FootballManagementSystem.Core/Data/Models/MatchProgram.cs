using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem.Core.Data.Models
{
    public class MatchProgram
    {
       

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public int FootballClubId { get; set; }

        [ForeignKey(nameof(FootballClubId))]
        public FootballClub FootballClub { get; set; }

      
    }
}
