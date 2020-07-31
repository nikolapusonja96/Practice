using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class GetAlbumbsOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            var albums = Db.Albums.Select(a => new AlbumDto
            {
                Id = a.AlbumId,
                Name = a.Title
            }).ToList();
            return new OperationResult
            {
                Data = albums
            };
        }
    }
}
