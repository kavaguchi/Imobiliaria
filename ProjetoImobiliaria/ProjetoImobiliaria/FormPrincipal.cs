using ProjetoImobiliaria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImobiliaria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa      pessoaAguinaldo      = new Pessoa();
            Endereco enderecoAguinaldo = new Endereco();

            pessoaAguinaldo.Nome = "AGUINALDO";
            pessoaAguinaldo.RG_IE = "1234";

            enderecoAguinaldo.Logradouro = "Avenida Nove de Julho";

            pessoaAguinaldo.Endereco = enderecoAguinaldo;


        }
    }
}
