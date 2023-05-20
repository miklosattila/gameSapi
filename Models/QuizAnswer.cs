namespace Catolog.Models
{
    public record QuizAnswer
    {
        public int Id {get;init;}

        public string Name {get;set;}="Quiz Answer";

        public string? Title {get;set;}

        public int CurentLife {get;set;}
        
        public int Score {get; set;}


        public int  QuizId {get;init;}

        public Quiz Quiz { get; set; }=null!;

        public List<Question>? AllQustionAnswers { get; set; }
        
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}