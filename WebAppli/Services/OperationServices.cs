using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Services
{
    public class OperationServices
    {
        public IsingletonInstanceOperation SingletonInstanceOperation { get;  }
        public ITransingOperation TransingOperation { get; }
        public IsingletonOperation SingletonOperation { get; }
        public IScodeOperation ScodeOperation { get; }

        public OperationServices(IsingletonInstanceOperation _SingletonInstanceOperation,
                                ITransingOperation _TransingOperation,
                                IsingletonOperation _SingletonOperation,
                                IScodeOperation _ScodeOperation
                                ) {
            this.SingletonInstanceOperation = _SingletonInstanceOperation;
            this.TransingOperation = _TransingOperation;
            this.SingletonOperation = _SingletonOperation;
            this.ScodeOperation = _ScodeOperation;

        }
    }
}
