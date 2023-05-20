namespace Catolog.Models
{
    public record Player
    {
        public int Id {get;init;}

        public string Name {get;set;}="Player";

        public int Age {get;set;}=1;

        public DateTimeOffset CreatedDate {get; init; }

        public DateTimeOffset ExitDate {get;set;}

        /// folyamatosan metsen 
        public int QuizScore {get; set;}=0;
        /// folyamatosan metsen 
        public int GameScore {get;set;}=0;

        public List<Map>? Maps { get; set; }

    }
}