namespace Catolog.Models
{
    public record MapEntityType
    {
        public int Id {get;init;}

        public string? Name {get;set;}


        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}