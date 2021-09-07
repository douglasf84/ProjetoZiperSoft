using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public sealed class ClientePF : BaseCliente
    {
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
    }
}
