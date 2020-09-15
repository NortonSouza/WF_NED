namespace WF_NED {
    partial class EditarCliente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
            this.btnFechar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.txtRG = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCPF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblData = new System.Windows.Forms.Label();
            this.tbDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTelSec = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelPrin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumResidencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(801, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(16, 17);
            this.btnFechar.TabIndex = 65;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Observações:";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.BackColor = System.Drawing.Color.Azure;
            this.txtObs.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(408, 159);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(376, 219);
            this.txtObs.TabIndex = 63;
            this.txtObs.Text = "";
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRG.Depth = 0;
            this.txtRG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Hint = "";
            this.txtRG.Location = new System.Drawing.Point(131, 267);
            this.txtRG.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.Size = new System.Drawing.Size(143, 23);
            this.txtRG.TabIndex = 62;
            this.txtRG.Text = "RG";
            this.txtRG.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Hint = "";
            this.txtCPF.Location = new System.Drawing.Point(131, 238);
            this.txtCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.Size = new System.Drawing.Size(143, 23);
            this.txtCPF.TabIndex = 61;
            this.txtCPF.Text = "CPF";
            this.txtCPF.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(131, 209);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(179, 23);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.Text = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(51, 305);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(102, 17);
            this.lblData.TabIndex = 59;
            this.lblData.Text = "Data Criação:";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // tbDataCriacao
            // 
            this.tbDataCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDataCriacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataCriacao.Location = new System.Drawing.Point(159, 305);
            this.tbDataCriacao.Mask = "00/00/0000";
            this.tbDataCriacao.Name = "tbDataCriacao";
            this.tbDataCriacao.Size = new System.Drawing.Size(100, 23);
            this.tbDataCriacao.TabIndex = 58;
            this.tbDataCriacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelSec
            // 
            this.txtTelSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelSec.Depth = 0;
            this.txtTelSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelSec.Hint = "";
            this.txtTelSec.Location = new System.Drawing.Point(131, 180);
            this.txtTelSec.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelSec.Name = "txtTelSec";
            this.txtTelSec.PasswordChar = '\0';
            this.txtTelSec.SelectedText = "";
            this.txtTelSec.SelectionLength = 0;
            this.txtTelSec.SelectionStart = 0;
            this.txtTelSec.Size = new System.Drawing.Size(143, 23);
            this.txtTelSec.TabIndex = 57;
            this.txtTelSec.Text = "Telefone Secundário";
            this.txtTelSec.UseSystemPasswordChar = false;
            // 
            // txtTelPrin
            // 
            this.txtTelPrin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelPrin.Depth = 0;
            this.txtTelPrin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelPrin.Hint = "";
            this.txtTelPrin.Location = new System.Drawing.Point(131, 151);
            this.txtTelPrin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelPrin.Name = "txtTelPrin";
            this.txtTelPrin.PasswordChar = '\0';
            this.txtTelPrin.SelectedText = "";
            this.txtTelPrin.SelectionLength = 0;
            this.txtTelPrin.SelectionStart = 0;
            this.txtTelPrin.Size = new System.Drawing.Size(143, 23);
            this.txtTelPrin.TabIndex = 56;
            this.txtTelPrin.Text = "Telefone Principal";
            this.txtTelPrin.UseSystemPasswordChar = false;
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCEP.Depth = 0;
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Hint = "";
            this.txtCEP.Location = new System.Drawing.Point(131, 122);
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(124, 23);
            this.txtCEP.TabIndex = 55;
            this.txtCEP.Text = "Cep";
            this.txtCEP.UseSystemPasswordChar = false;
            // 
            // txtNumResidencia
            // 
            this.txtNumResidencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumResidencia.Depth = 0;
            this.txtNumResidencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumResidencia.Hint = "";
            this.txtNumResidencia.Location = new System.Drawing.Point(399, 64);
            this.txtNumResidencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumResidencia.Name = "txtNumResidencia";
            this.txtNumResidencia.PasswordChar = '\0';
            this.txtNumResidencia.SelectedText = "";
            this.txtNumResidencia.SelectionLength = 0;
            this.txtNumResidencia.SelectionStart = 0;
            this.txtNumResidencia.Size = new System.Drawing.Size(78, 23);
            this.txtNumResidencia.TabIndex = 54;
            this.txtNumResidencia.Text = "Num";
            this.txtNumResidencia.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(131, 93);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(179, 23);
            this.txtBairro.TabIndex = 52;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRua.Depth = 0;
            this.txtRua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Hint = "";
            this.txtRua.Location = new System.Drawing.Point(131, 64);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(262, 23);
            this.txtRua.TabIndex = 50;
            this.txtRua.Text = "Rua";
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Hint = "";
            this.txtCidade.Location = new System.Drawing.Point(316, 93);
            this.txtCidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.Size = new System.Drawing.Size(77, 23);
            this.txtCidade.TabIndex = 51;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(131, 35);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(262, 23);
            this.txtNome.TabIndex = 49;
            this.txtNome.Text = "Nome";
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnEditarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCli.FlatAppearance.BorderSize = 0;
            this.btnEditarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCli.ForeColor = System.Drawing.Color.White;
            this.btnEditarCli.Location = new System.Drawing.Point(63, 369);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(113, 50);
            this.btnEditarCli.TabIndex = 66;
            this.btnEditarCli.Text = "Editar e Salvar";
            this.btnEditarCli.UseVisualStyleBackColor = false;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(131, 12);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(49, 23);
            this.txtID.TabIndex = 67;
            this.txtID.Text = "id";
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(51, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 68;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblRua
            // 
            this.lblRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(51, 70);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(37, 17);
            this.lblRua.TabIndex = 69;
            this.lblRua.Text = "Rua:";
            this.lblRua.Click += new System.EventHandler(this.lblRua_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(51, 99);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 17);
            this.lblBairro.TabIndex = 70;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(51, 128);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 17);
            this.lblCep.TabIndex = 71;
            this.lblCep.Text = "CEP:";
            this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tel. Princi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tel. Sec:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Emai:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "CPF:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "RG:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(859, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnEditarCli);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbDataCriacao);
            this.Controls.Add(this.txtTelSec);
            this.Controls.Add(this.txtTelPrin);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtNumResidencia);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnEditarCli;
        public System.Windows.Forms.RichTextBox txtObs;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRG;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCPF;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        public System.Windows.Forms.MaskedTextBox tbDataCriacao;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtTelSec;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtTelPrin;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNumResidencia;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCidade;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}