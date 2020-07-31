using LaboratorijskiKolokvijum.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class DeleteSongOperation : EfOperation
    {
        private int songId;

        public DeleteSongOperation(int songId)
        {
            //provera
            var song = Db.Tracks.Find(songId);

            if(song == null)
            {
                throw new ArgumentException($"song with id {songId} already exists in database.");
            }

            this.songId = songId;
        }

        public override OperationResult Execute()
        {
            if(Db.InvoiceLines.Any(i=>i.TrackId == songId))
            {
                throw new InvalidOperationException($"song with id {songId} can not be deleted because it is contained in order table");
            }

            var track = Db.Tracks.Find(songId);

            Db.Tracks.Remove(track);

            foreach(var playlist in track.Playlists)
            {
                playlist.Tracks.Remove(track); //brisemo iz plejlisti tu pesmu

            }

            Db.SaveChanges();

            return new OperationResult();
        }
    }
}
