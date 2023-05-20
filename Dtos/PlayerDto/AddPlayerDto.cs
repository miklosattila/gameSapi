using System.ComponentModel.DataAnnotations;

namespace Catolog.Dtos.PlayerDto
{
    public record AddPlayerDto{
         
        [Required]
        public string? Name {get;set;} = "Player";

        [Required]
        [Range(1,135)]
         public int Age {get;set;}

    }
}