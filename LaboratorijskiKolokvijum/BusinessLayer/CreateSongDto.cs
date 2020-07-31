using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer
{
    public class CreateSongDto : BaseDto
    {
        public int MediaTypeId { get; set; }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public string SongName { get; set; }
        public string Composer { get; set; }
        public decimal Price { get; set; }
    }
}
