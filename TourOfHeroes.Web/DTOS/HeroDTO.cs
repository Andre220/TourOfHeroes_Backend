using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourOfHeroes.Web.DTOS
{
    public class HeroDTO
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; private set; }
        
        [Required]
        public string AlterEgo { get; private set; }
    }
}
