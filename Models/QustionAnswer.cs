namespace Catolog.Models
{
    public record QustionAnswer
    {
        public int  Id {get;init;}

        public string? Content {get;set;}

        public string? Type {get;set;}

        public bool Corrrect {get;set;}

        public int QuestionId {get;init;}

        public Question Question { get; set; }=null!;
        
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }

        


        
    }
}