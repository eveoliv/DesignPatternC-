using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor visitor);
    }
}
