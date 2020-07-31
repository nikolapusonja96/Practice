using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class GetSongsOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            var query = Db.Tracks.AsQueryable(); //gradjenje upita

            //pesme koje su bar 1 kupljene...

            query.Where(t => t.InvoiceLines.Any());

            
            var result = query.Select(t => new SongDto
            {
                Id = t.TrackId,
                AlbumName = t.Album.Title,
                MediaType = t.MediaType.Name,
                Name = t.Name,
                Price = t.UnitPrice,
                PlaylistNames = t.Playlists.Select(p => p.Name),
                ArtistName = t.Album.Artist.Name,
                SoldItems = t.InvoiceLines.Count
            }).ToList();
            return new OperationResult
            {
                Data = result
            };
        }
    }
}
