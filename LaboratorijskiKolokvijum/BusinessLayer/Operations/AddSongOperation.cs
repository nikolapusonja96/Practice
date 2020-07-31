using LaboratorijskiKolokvijum.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class AddSongOperation : EfOperation
    {
        private readonly CreateSongDto dto;

        public AddSongOperation(CreateSongDto dto)
        {
            var albumId = Db.Albums.Find(dto.AlbumId);
            var MediaTypeId = Db.MediaTypes.Find(dto.MediaTypeId);
            var GenreId = Db.Genres.Find(dto.GenreId);

            if(albumId == null)
            {
                throw new ArgumentException("Album ne postoji");
            }

            this.dto = dto;
        }

        public override OperationResult Execute()
        {
            var newId = Db.Tracks.OrderByDescending(i => i.TrackId).First().TrackId + 1;
            var track = new Track
            {
                TrackId = newId,
                AlbumId = dto.AlbumId,
                Name=dto.SongName,
                Composer=dto.Composer,
                GenreId=dto.GenreId,
                UnitPrice = dto.Price,
                MediaTypeId=dto.MediaTypeId
            };

            Db.Tracks.Add(track);
            Db.SaveChanges();


            return new OperationResult();
        }
    }
}
