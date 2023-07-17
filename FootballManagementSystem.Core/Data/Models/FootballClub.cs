using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem.Core.Data.Models
{
    public class FootballClub
    {
        public FootballClub()
        {
            this.Employees = new List<Employee>();
            this.MatchesPrograms = new List<MatchProgram>();
            this.MedicalLists = new List<MedicalList>();
            this.Schedules = new List<Schedule>();
        }
        
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string Stadium { get; set; }

        [Required]
        public string LogoImg { get; set; }

        public bool IsDeleted { get; set; }

        public List<Employee> Employees { get; set; }

        public List<MatchProgram> MatchesPrograms { get; set; }

        public List<MedicalList> MedicalLists { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}
