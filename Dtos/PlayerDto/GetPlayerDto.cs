namespace Catolog.Dtos.PlayerDto
{
    public record GetPlayerDto
    {
        public int Id {get;init;}

        public string Name {get;set;} ="Player";

        public int QuizScore {get; set;} =0;

        public int GameScore {get;set;} =0;


    }
}
