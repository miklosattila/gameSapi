using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.MapDto
{
    public class MapEntityDto
    {
        public MapEntityType? EntityType {get;set;}
        public int Xcoordinate {get;set;}

        public int Ycoordinate {get;set;}

    }
}