namespace Catolog.Models
{
    public record MapEntityType
    {
        public int Id {get;init;}

        public int? Code {get;set;}
        public string? Name {get;set;}

        public List<MapEntity>? MapEntity { get; set; }
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}