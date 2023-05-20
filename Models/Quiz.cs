namespace Catolog.Models
{
    public record Quiz
    {
        public int Id { get; init; }
        public string Name { get; set; } = "Quiz";
        public string? Title { get; set; }
        public int CurrentLife { get; set; }
        public int Score { get; set; }
        public int MapId { get; set; }
        public Map Map { get; set; } = null!;
        public List<Question>? Questions { get; set; }
        public List<QuizAnswer>? QuizAnswers { get; set; }
        public DateTimeOffset CreatedDate { get; init; }
        public string? CreatedAT { get; init; }



        
    }
}