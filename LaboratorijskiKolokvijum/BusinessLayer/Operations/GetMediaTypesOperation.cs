using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer.Operations
{
    public class GetMediaTypesOperation : EfOperation
    {
        public override OperationResult Execute()
        {
            var types = Db.MediaTypes.Select(m => new MediaTypeDto
            {
                Id = m.MediaTypeId,
                Name = m.Name
            }).ToList();
            return new OperationResult
            {
                Data = types
            };
        }
    }
}
