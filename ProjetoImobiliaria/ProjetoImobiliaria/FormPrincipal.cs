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
            //Instanciei um objeto chamado pessoaAguinaldo
            PessoaAguinaldoTeste pessoaAguinaldo  = new PessoaAguinaldoTeste();
            

            pessoaAguinaldo.Nome = "AGUINALDO";
            pessoaAguinaldo.NomeDaMae = "maria";
            pessoaAguinaldo.NomeDoCachorro = "Marlon";
            pessoaAguinaldo.NumeroCarMotorista = "87956444";
            
            //aqui é tipo List?
            //public string ListaDeFilmesFavoritos { get; set; }

            pessoaAguinaldo.RG_IE = "1234";
            pessoaAguinaldo.CPF_CNPJ = "258068982511";
            pessoaAguinaldo.PessoaFisicaOuJuridica = "Fisica";
            pessoaAguinaldo.NumeroCelular= "99955558777";
            pessoaAguinaldo.Endereco = "Avenida cosmos n89";




        }
    }
}
