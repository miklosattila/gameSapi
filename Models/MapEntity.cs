namespace Catolog.Models
{
    public record MapEntity
    {
        public int Id {get;init;}

        public int MapId {get;set;}
        public int  MapEntityTypeid {get;set;}
        public MapEntityType MapEntityType {get;set;}
    
        public int Xcoordinate {get;set;}

        public int Ycoordinate {get;set;}

        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }



        
    }
}