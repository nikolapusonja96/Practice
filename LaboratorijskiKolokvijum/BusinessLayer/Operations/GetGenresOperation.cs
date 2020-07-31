using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class GetGenresOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            var genres = Db.Genres.Select(g => new GenreDto
            {
                Id = g.GenreId,
                Name = g.Name
            }).ToList();
            return new OperationResult {
                Data = genres
            };
        }
    }
}
