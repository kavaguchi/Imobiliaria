using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImobiliaria.Classes
{
    class Pessoa
    {
		public string Nome { get; set; }
		public string RG_IE { get; set; }
		public string CPF_CNPJ { get; set; }
		public string TipoPessoa { get; set; }
		public string PessoaFisicaOuJuridica { get; set; }
		public Endereco Endereco { get; set; }
        public List<Telefone> ListaTelefonica { get; set; }
	}
}
