using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer
{
    public class SongDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public IEnumerable<string> PlaylistNames { get; set; } = new List<string>();
        public int PlaylistCount => PlaylistNames.Count();
        public string MediaType { get; set; }
        public decimal Price { get; set; }
        public int SoldItems { get; set; }

    }
}
