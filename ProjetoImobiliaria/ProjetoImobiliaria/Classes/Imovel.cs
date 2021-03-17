using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImobiliaria.Classes
{
    class Imovel
    {
			public int Codigo { get; set; }
			public int TipoImovel { get; set; }
			public Endereco Endereco { get; set; }
			public string Area { get; set; }
			public double Metragem { get; set; }
			public double Valor { get; set; }
			public int QuantidadeDeQuartos { get; set; }
			public int QuantidadeDeBanheiros { get; set; }
			public int Andar { get; set; }
			public string Observacao { get; set; }
			public int NumeroDeVagas { get; set; }
			public double ValorDoCondominio { get; set; }
			public double IdadeDoImovel { get; set; }
			public bool Piscina { get; set; }
			public bool Financia { get; set; }
			public bool Permuta { get; set; }
			public List<string> Imagens { get; set; }


		
	}
}
