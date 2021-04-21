using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpresaFacade fachada = new EmpresaFacadeSingleton().Instancia;
        }
    }
}
