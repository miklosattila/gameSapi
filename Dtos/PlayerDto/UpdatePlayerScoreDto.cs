
namespace Catolog.Dtos.PlayerDto
{
    public record UpdatePlayerScoreDto{
        public int Id {get;init;}
         
        public int QuizScore {get; set;}

        public int GameScore {get;set;}

    }
}