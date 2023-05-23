namespace Catolog.Models
{
    public record MapEntity
    {
        public int Id {get;init;}

        public int MapId {get;set;}

        public MapEntityType? EntityType {get;set;}
        public int Xcoordinate {get;set;}

        public int Ycoordinate {get;set;}

        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}