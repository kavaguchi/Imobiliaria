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
    public partial class CadastroDeImovel : Form
    {
        public CadastroDeImovel()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-VN91J66\NOTEKAVA;Database=Imobiliaria;Trusted_Connection=True;";

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txb_Nome.Text;
            pessoa.Email = txb_Email.Text;
            pessoa.ListaTelefonica = null;

            Imovel imovel = new Imovel();
            imovel.Codigo = 0;

            Endereco endereco = new Endereco();
            endereco.Logradouro = txb_Endereco.Text;
            endereco.Numero = txb_Numeo.Text;
            endereco.Complemento = txb_Complemento.Text;
            endereco.Bairro = txb_Bairro.Text;
            endereco.Cidade = txb_Cidade.Text;
            imovel.TipoImovel = int.Parse(txb_TipoImovel.Text);
            imovel.Endereco = endereco;

            imovel.Observacao = txb_Descricao.Text;

            //imovel.Area = 
            //imovel.Metragem 
            //imovel.Valor
            //imovel.QuantidadeDeQuartos 
            //imovel.QuantidadeDeBanheiros
            //imovel.Andar
            //imovel.NumeroDeVagas
            //imovel.ValorDoCondominio
            //imovel.IdadeDoImovel
            //imovel.Piscina
            //imovel.Financia
            //imovel.Permuta
            //public List<string> Imagens { get; set; }

            string sql;
            if (true)
            {

                // Comando SQL
                sql = "INSERT INTO Pessoa (Nome)" + "VALUES ('" + pessoa.Nome + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
        
        SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }


        }
}
}
