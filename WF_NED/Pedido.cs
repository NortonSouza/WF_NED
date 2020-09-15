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

namespace WF_NED {
    public partial class Pedido : Form {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string strSQL;

        public Pedido() {
            InitializeComponent();
        }

        private void btnConsultarCrudCliente_Click(object sender, EventArgs e) {

            EditarCliente edCli = new EditarCliente();
            AddOwnedForm(edCli);
            edCli.FormBorderStyle = FormBorderStyle.None;
            edCli.TopLevel = false;
            edCli.Dock = DockStyle.Fill;
            this.Controls.Add(edCli);
            this.Tag = edCli;
            edCli.BringToFront();
            edCli.Show();

        }
    }
}
