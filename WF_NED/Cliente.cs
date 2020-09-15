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
    public partial class Cliente : Form {


        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string strSQL;

        public Cliente() {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e) {

        }

        

        private void dataGrigCliente_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnExibirCliente_Click_1(object sender, EventArgs e) {
            try {
                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "SELECT * FROM tbCLIENTE";

                DataSet dataSet = new DataSet();
                dataAdapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();

                dataAdapter.Fill(dataSet);

                dataGrigCliente.DataSource = dataSet.Tables[0];


            } catch (Exception ex) {

                MessageBox.Show(ex.Message);


            } finally {
                connection.Close();

                connection = null;

            }
        }


        private void btnCriar_Click_1(object sender, EventArgs e) {

            CriarCliente criarCliente = new CriarCliente();
            AddOwnedForm(criarCliente);
            criarCliente.FormBorderStyle = FormBorderStyle.None;
            criarCliente.TopLevel = false;
            criarCliente.Dock = DockStyle.Fill;
            this.Controls.Add(criarCliente);
            this.Tag = criarCliente;
            criarCliente.BringToFront();
            criarCliente.Show();


            
        }
        public int id { get; set; }
        private void btnExcluirCliente_Click(object sender, EventArgs e) {
            try {
                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "DELETE tbCLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

                command = new SqlCommand(strSQL, connection);

                
                if (dataGrigCliente.SelectedRows.Count > 0) {
                    id = int.Parse(dataGrigCliente.CurrentRow.Cells[13].Value.ToString());
                command.Parameters.AddWithValue("@ID_CLIENTE", id.ToString());
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso!");
                } else {
                    MessageBox.Show("Cliente Não Encontrado");
                }

              

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);


            } finally {
                connection.Close();
                command.Clone();
                connection = null;
                command = null;
            }
        }

        private void btnEditarCli_Click_1(object sender, EventArgs e) {
            try {
                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "UPDATE tbCLIENTE SET NOME = @NOME, NUMERO = @NUMERO, ENDERECO = @ENDERECO WHERE ID = @ID";

                command = new SqlCommand(strSQL, connection);

                
                connection.Open();
                command.ExecuteNonQuery();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);


            } finally {
                connection.Close();
                command.Clone();
                connection = null;
                command = null;
            }
        }

        private void btnConsultarCrudCliente_Click_1(object sender, EventArgs e) {
            try {
                EditarCliente edCli = new EditarCliente();

                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);

                strSQL = "SELECT * FROM tbCLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

                command = new SqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID_CLIENTE", tbPesquisarTelefone.Text);



                if (dataGrigCliente.SelectedRows.Count > 0) {
                    edCli.txtNome.Text = dataGrigCliente.CurrentRow.Cells[0].Value.ToString();
                    edCli.txtRua.Text = dataGrigCliente.CurrentRow.Cells[1].Value.ToString();
                    edCli.txtBairro.Text = dataGrigCliente.CurrentRow.Cells[2].Value.ToString();
                    edCli.txtCidade.Text = dataGrigCliente.CurrentRow.Cells[3].Value.ToString();
                    edCli.txtNumResidencia.Text = dataGrigCliente.CurrentRow.Cells[4].Value.ToString();
                    edCli.txtCEP.Text = dataGrigCliente.CurrentRow.Cells[5].Value.ToString();
                    edCli.txtTelPrin.Text = dataGrigCliente.CurrentRow.Cells[6].Value.ToString();
                    edCli.txtTelSec.Text = dataGrigCliente.CurrentRow.Cells[7].Value.ToString();
                    edCli.tbDataCriacao.Text = dataGrigCliente.CurrentRow.Cells[8].Value.ToString();
                    edCli.txtEmail.Text = dataGrigCliente.CurrentRow.Cells[9].Value.ToString();
                    edCli.txtCPF.Text = dataGrigCliente.CurrentRow.Cells[10].Value.ToString();
                    edCli.txtRG.Text = dataGrigCliente.CurrentRow.Cells[11].Value.ToString();
                    edCli.txtObs.Text = dataGrigCliente.CurrentRow.Cells[12].Value.ToString();
                    edCli.txtID.Text = dataGrigCliente.CurrentRow.Cells[13].Value.ToString();

                    edCli.ShowDialog();


                } else {
                    MessageBox.Show("Selecione a linha completa para poder consultar o cliente.");
                }


                connection.Open();
                command.ExecuteNonQuery();

                dataReader = command.ExecuteReader();



            } catch (Exception ex) {

                MessageBox.Show(ex.Message);


            } finally {
                connection.Close();

                connection = null;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                var sc = ConfigurationManager.ConnectionStrings["conexaoSQL"].ToString();
                connection = new SqlConnection(sc);


                
                string pesquisar = tbPesquisarTelefone.Text.ToLower();

                dataGrigCliente.ClearSelection();

                foreach (DataGridViewRow row in dataGrigCliente.Rows) {
                    if (row.Cells["TELEFONE_PRIN"].Value != null) {

                        if (row.Cells["TELEFONE_PRIN"].Value.ToString().ToLower().Equals(pesquisar)) {
                            MessageBox.Show("Busca realizada com sucesso! O Telefone possui cadastro!");
                            row.Selected = true;
                            break;
                        }
                        if (row.Cells["Nome"].Value.ToString().ToLower().Equals(pesquisar)) {
                            MessageBox.Show("Busca realizada com sucesso! O Nome possui cadastro!");
                            row.Selected = true;
                            break;
                        }

                    }else if (row.Cells["ID"].Value != null) {


                    }
                }


                connection.Open();

                //dataAdapter.Fill(dataSet);

                //dataGrigCliente.DataSource = dataSet.Tables[0];



            } catch (Exception ex) {

                MessageBox.Show("Cliente não localizado!");


            } finally {
                connection.Close();

                connection = null;

            }
        }
    }
}
