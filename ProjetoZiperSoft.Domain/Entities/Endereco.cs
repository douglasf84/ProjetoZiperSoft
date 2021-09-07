using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public sealed class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public ICollection<ClientePF> ClientesPF { get; set; }
        public ICollection<ClientePJ> ClientesPJ { get; set; }
    }
}
