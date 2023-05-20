namespace Catolog.Models
{
    public record MapEntityType
    {
        public int Id {get;init;}

        public string? Name {get;set;}

        public int MapEntityId { get; set; }

        public MapEntity MapEntity { get; set; } =null!;

        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}