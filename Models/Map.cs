namespace Catolog.Models
{
    public record Map
    {
        public int Id {get;init;}

        public List<Player> Players {get; set;}=null!;

        public int  PlayerId {get;set;}

        public List<Quiz>? Quiz { get; set; }
        
        public string? Name {get;set;}

        public int Latitude {get;set;}

        public int Longitude {get;set;}

        public List<MapEntity>? MapEntities { get; set; }
        
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAt {get; init; }



        
    }
}