namespace Catolog.Models
{
    public record Question
    {
        public int Id {get;init;}

        public string Content {get;set;}="Qustion?";

        //Enum type
        public string Type {get;set;}="Type";

        public int Rank {get;set;}

        public int QuizId {get;init;}

        public Quiz Quiz { get; set; }=null!;

        public List<QustionAnswer>? QustionAnswers { get; set; }

        public List<QustionAnswerPicked>? QustionAnswersPicked { get; set; }
        
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}