using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Models
{
    public class PlayerMap
    {
        
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int MapId { get; set; }
        public Map Map { get; set; } = null!;
        public Player Player { get; set; } = null!;
    }
}