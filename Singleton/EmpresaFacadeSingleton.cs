using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Facade
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade instancia = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
