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
           
            
            //aqui é tipo List?
            //public string ListaDeFilmesFavoritos { get; set; }

            




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
                "SELECT NOME from Imobiliaria..Pessoa ";

            // Specify the parameter value.

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}