using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImobiliaria
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());

            
/*enum TipoPessoa short 
{
	Cliente 		= 1,
	Corretor 		= 2,
	Proprietario	= 3 
}

enum TipoTelefone short 
{
	Principal 	= 1,
	Recado 		= 2,
	Comercial	= 3,
	Residencial = 4,
	Celular		= 5
}

enum TipoImovel short
{
	Terreno 	= 1,
	Casa		= 2,
	Apartamento	= 3,
	Chacara		= 4,
	Galpao		= 5
}
*/


        }

    }
}
