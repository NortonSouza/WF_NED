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
    public partial class Form1 : Form {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1() {
            InitializeComponent();
            //customizedComponent();
        }

        private void panelClienteSubmenu_Paint(object sender, PaintEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        //private void customizedComponent() {
        //panelClienteSubmenu.Visible = false;
        //panelPedidoSubmenu.Visible = false;
        //}

        //private void hideSubmenu() {
        //    if (panelClienteSubmenu.Visible == true) {
        //        panelClienteSubmenu.Visible = false;
        //    }
        //    if (panelPedidoSubmenu.Visible == true) {
        //        panelPedidoSubmenu.Visible = false;
        //    }
        //}

        //private void showSubmenu(Panel submenu) {
        //    if (submenu.Visible == false) {
        //        hideSubmenu();
        //        submenu.Visible = true;
        //    } else
        //        submenu.Visible = false;
        //}

        //private void btnClienteSubmenu_Click(object sender, EventArgs e) {
        //    showSubmenu(panelClienteSubmenu);
        //}

        //private void btnPedidoSubmenu_Click(object sender, EventArgs e) {
        //    showSubmenu(panelPedidoSubmenu);
        //}

        private void btnCadastrarCliente_Click(object sender, EventArgs e) {



        }

        private void btnHome_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            this.SendToBack();
        }


        public void AbrirFormEnPanel(object Formhijo) {
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(fh);
            this.pnlCentral.Tag = fh;
            fh.Show();
        }

        private void btnPEDIDO_Click(object sender, EventArgs e) {

        }

        private void pbFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        int lx;
        int ly;

        private void pbExpandir_Click(object sender, EventArgs e) {

            //this.WindowState = FormWindowState.Maximized;
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbMin.Visible = true;
            pbExpandir.Visible = false;

        }

        private void pbMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMin_Click(object sender, EventArgs e) {
            //this.WindowState = FormWindowState.Normal;]
            this.Location = new Point(lx, ly);
            this.Size = new Size(852,496);
            pbMin.Visible = false;
            pbExpandir.Visible = true;
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e) {

        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCLI_Click(object sender, EventArgs e) {
            AbrirFormEnPanel(new Cliente());

        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message msj) {
            const int CoordenadaWPF = 0x84;
            const int DesEsquerda = 16;
            const int DesDireita = 17;
            if (msj.Msg == CoordenadaWPF) {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)(msj.LParam.ToInt64() & 0xFFFF0000 >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamanhoAreaForm = ClientSize;
                if(CoordenadaArea.X >= TamanhoAreaForm.Width - 16 && CoordenadaArea.Y >= TamanhoAreaForm.Height - 17) {
                    msj.Result = (IntPtr)(IsMirrored ? DesEsquerda : DesDireita);
                    return;
                }

            }
            base.WndProc(ref msj);

        }

        private void button1_Click(object sender, EventArgs e) {
        
                AbrirFormEnPanel(new Pedido());

            
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void materialLabel1_Click(object sender, EventArgs e) {

        }
    }
}

