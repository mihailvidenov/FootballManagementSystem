using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem.Core.Data.Models
{
    public class Employee 
    {
        public Employee()
        {
            this.MatchesPrograms = new List<MatchProgram>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public DateTime ContractExpired { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int Age { get; set; }

        public bool isDeleted { get; set; }


        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        public int FootballClubId { get; set; }

        [ForeignKey(nameof(FootballClubId))]
        public FootballClub FootballClub { get; set; }

        public List<MatchProgram> MatchesPrograms { get; set; }
    }

}