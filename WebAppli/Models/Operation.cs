using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{

    public interface Ioperation {
         Guid OperationId { get;}
    }

    public interface IsingletonOperation : Ioperation {

    }
    public interface ITransingOperation : Ioperation
    {

    }
    public interface IsingletonInstanceOperation : Ioperation
    {

    }
    public interface IScodeOperation : Ioperation
    {

    }

    public class Operation : IsingletonOperation, IScodeOperation, ITransingOperation,IsingletonInstanceOperation
    {
        public Operation()
        {
            this._guid = Guid.NewGuid();
        }
        public Operation(Guid _NewGuid)
        {
            this._guid = _NewGuid;
        }
        private Guid _guid;
        public Guid OperationId { get { return _guid; } }
    }
}
