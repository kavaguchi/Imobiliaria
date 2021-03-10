using ProjetoImobiliaria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



            Pessoa hugo = new Pessoa();

            hugo.Nome = "Hugo";

            #region Endereco
            Endereco enderecoDoHugo = new Endereco();
            enderecoDoHugo.Logradouro = "Rua da casa do Hugo";
            enderecoDoHugo.CEP = "13210000";
            enderecoDoHugo.Cidade = "JUNDIAI";
            enderecoDoHugo.Bairro = "BAIRRO DO HUGO";
            enderecoDoHugo.Complemento = "CASA DO HUGO";
            enderecoDoHugo.Numero = "000";
            #endregion

            hugo.Endereco = enderecoDoHugo;

            // pesquisar o que é dado primitivo

            #region celular
            Telefone celular = new Telefone();
            celular.DDD = "11";
            celular.Numero = "980980980";
            celular.tipoTelefone = "CELULAR";
            #endregion

            #region TelefoneFixo
            Telefone telefoneFixo = new Telefone();
            telefoneFixo.DDD = "11";
            telefoneFixo.Numero = "45554444";
            telefoneFixo.tipoTelefone = "FIXO";
            #endregion

            // para adicionar dados em uma lista, deve-se usar o método Add();
            List<Telefone> listaTelefonica = new List<Telefone>();
            listaTelefonica.Add(celular);
            listaTelefonica.Add(telefoneFixo);
            hugo.ListaTelefonica = listaTelefonica;

            MessageBox.Show("");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString =
                        "Server=DESKTOP-VN91J66\\NOTEKAVA;Database=Imobiliaria;User Id=sa;Password=hugo1234;";



            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                    + "WHERE UnitPrice > @pricePoint "
                    + "ORDER BY UnitPrice DESC;";

            // Specify the parameter value.
            int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
            }
    }
}