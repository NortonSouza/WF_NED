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
    public partial class CriarCliente : Form {


        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string strSQL;

        public CriarCliente() {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e) {
            try {
                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "INSERT INTO tbCLIENTE (NOME, RUA, BAIRRO, CIDADE, " +
                    "NUM_RESIDENCIA,CEP,TELEFONE_PRIN,TELEFONE_SEC,DATA_INCLUSAO,EMAIL,CPF,RG,OBSERVACOES) " +
                    "VALUES (@NOME, @RUA, @BAIRRO, @CIDADE, @NUM_RESIDENCIA, @CEP, @TELEFONE_PRIN," +
                    " @TELEFONE_SEC, @DATA_INCLUSAO,@EMAIL,@CPF,@RG,@OBSERVACOES)";

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
          
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso!");
                this.Close();


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
    }
}
