using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
   public sealed class ClientePJ : BaseCliente
    {
        public string Ie { get; private set; }
        public string Cnpj { get; private set; }
        public string Site { get; set; }        
    }
}
