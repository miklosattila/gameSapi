using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.PlayerDto
{
    public class GetMapWithAllResourcesDto
    {
        public int Id {get;init;}
    
        public string? Name {get;set;}

        public int Latitude {get;set;}

        public int Longitude {get;set;}

        public List<MapEntity>? MapEntities { get; set; }
        
    }
}