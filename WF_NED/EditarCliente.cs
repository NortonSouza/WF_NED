using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Configuration;

namespace WF_NED {
    public partial class EditarCliente : Form {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string strSQL;

        public EditarCliente() {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e) {

        }

        private void btnEditarCli_Click(object sender, EventArgs e) {
            try {
                int cod;
                EditarCliente EditarCliente = new EditarCliente();

                Cliente id = new Cliente();

                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "UPDATE tbCLIENTE SET NOME = @NOME, RUA = @RUA, BAIRRO = @BAIRRO, CIDADE = @CIDADE, NUM_RESIDENCIA = @NUM_RESIDENCIA," +
                        "CEP = @CEP, TELEFONE_PRIN = @TELEFONE_PRIN, TELEFONE_SEC = @TELEFONE_SEC, DATA_INCLUSAO = @DATA_INCLUSAO, EMAIL = @EMAIL," +
                        "CPF = @CPF, RG = @RG, OBSERVACOES = @OBSERVACOES WHERE ID_CLIENTE = @ID_CLIENTE";
                
                    command = new SqlCommand(strSQL, connection);

                    command.Parameters.AddWithValue("@NOME", txtNome.Text);
                    command.Parameters.AddWithValue("@RUA", txtRua.Text);
                    command.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                    command.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                    command.Parameters.AddWithValue("@NUM_RESIDENCIA", txtNumResidencia.Text);
                    command.Parameters.AddWithValue("@CEP", txtCEP.Text);
                    command.Parameters.AddWithValue("@TELEFONE_PRIN", txtTelPrin.Text);
                    command.Parameters.AddWithValue("@TELEFONE_SEC", txtTelSec.Text);
                    DateTime dt = DateTime.Parse(tbDataCriacao.Text);
                    command.Parameters.AddWithValue("@DATA_INCLUSAO", dt);
                    command.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    command.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    command.Parameters.AddWithValue("@RG", txtRG.Text);
                    command.Parameters.AddWithValue("@OBSERVACOES", txtObs.Text);
                    command.Parameters.AddWithValue("@ID_CLIENTE", txtID.Text);



                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Salvo com Sucesso!");

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);


            } finally {
                connection.Close();
                command.Clone();
                connection = null;
                command = null;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EditarCliente_Load(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void lblData_Click(object sender, EventArgs e) {

        }

        private void lblBairro_Click(object sender, EventArgs e) {

        }

        private void lblCep_Click(object sender, EventArgs e) {

        }

        private void lblRua_Click(object sender, EventArgs e) {

        }

        private void lblNome_Click(object sender, EventArgs e) {

        }
    }
}
