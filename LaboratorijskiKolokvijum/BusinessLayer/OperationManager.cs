using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskiKolokvijum.BusinessLayer
{
    public class OperationManager
    {
        private OperationManager()
        {

        }
        private static OperationManager singleton;
        public static OperationManager Instance
        {
            get
            {
                if (singleton == null)
                {
                    return new OperationManager();
                }
                return singleton;
            }
        }
        public OperationResult ExecuteOperation(Operation op)
        {
            var result = new OperationResult();

            try
            {
                return op.Execute();
            }
            catch (Exception ex)
            {
                LogException(ex);
                result.ErrorMessages.Add("Doslo je do greske kontaktirajte admina");
                return result;
            }

        }
        private void LogException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
