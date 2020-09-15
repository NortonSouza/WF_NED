namespace WF_NED {
    partial class Cliente {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrigCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultarCrudCliente = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnExibirCliente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Label();
            this.tbPesquisarTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelPrinPesquisa = new System.Windows.Forms.Label();
            this.btnPesquisarPorTel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrigCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrigCliente
            // 
            this.dataGrigCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrigCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.dataGrigCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrigCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrigCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrigCliente.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGrigCliente.Location = new System.Drawing.Point(12, 94);
            this.dataGrigCliente.Name = "dataGrigCliente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrigCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrigCliente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrigCliente.Size = new System.Drawing.Size(916, 424);
            this.dataGrigCliente.TabIndex = 26;
            this.dataGrigCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrigCliente_CellContentClick);
            // 
            // btnConsultarCrudCliente
            // 
            this.btnConsultarCrudCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnConsultarCrudCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarCrudCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarCrudCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCrudCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCrudCliente.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCrudCliente.Location = new System.Drawing.Point(250, 25);
            this.btnConsultarCrudCliente.Name = "btnConsultarCrudCliente";
            this.btnConsultarCrudCliente.Size = new System.Drawing.Size(113, 50);
            this.btnConsultarCrudCliente.TabIndex = 28;
            this.btnConsultarCrudCliente.Text = "Consultar";
            this.btnConsultarCrudCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCrudCliente.Click += new System.EventHandler(this.btnConsultarCrudCliente_Click_1);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(131, 25);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(113, 50);
            this.btnCriar.TabIndex = 22;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click_1);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCliente.Location = new System.Drawing.Point(868, 52);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(60, 36);
            this.btnExcluirCliente.TabIndex = 29;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnExibirCliente
            // 
            this.btnExibirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnExibirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirCliente.FlatAppearance.BorderSize = 0;
            this.btnExibirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCliente.ForeColor = System.Drawing.Color.White;
            this.btnExibirCliente.Location = new System.Drawing.Point(12, 25);
            this.btnExibirCliente.Name = "btnExibirCliente";
            this.btnExibirCliente.Size = new System.Drawing.Size(113, 50);
            this.btnExibirCliente.TabIndex = 27;
            this.btnExibirCliente.Text = "Exibir";
            this.btnExibirCliente.UseVisualStyleBackColor = false;
            this.btnExibirCliente.Click += new System.EventHandler(this.btnExibirCliente_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(911, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(17, 17);
            this.btnFechar.TabIndex = 32;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tbPesquisarTelefone
            // 
            this.tbPesquisarTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisarTelefone.Location = new System.Drawing.Point(420, 49);
            this.tbPesquisarTelefone.Name = "tbPesquisarTelefone";
            this.tbPesquisarTelefone.Size = new System.Drawing.Size(113, 23);
            this.tbPesquisarTelefone.TabIndex = 33;
            // 
            // lblTelPrinPesquisa
            // 
            this.lblTelPrinPesquisa.AutoSize = true;
            this.lblTelPrinPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPrinPesquisa.Location = new System.Drawing.Point(417, 29);
            this.lblTelPrinPesquisa.Name = "lblTelPrinPesquisa";
            this.lblTelPrinPesquisa.Size = new System.Drawing.Size(107, 17);
            this.lblTelPrinPesquisa.TabIndex = 34;
            this.lblTelPrinPesquisa.Text = "Nome/Telefone";
            // 
            // btnPesquisarPorTel
            // 
            this.btnPesquisarPorTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnPesquisarPorTel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPorTel.FlatAppearance.BorderSize = 0;
            this.btnPesquisarPorTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPorTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorTel.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarPorTel.Location = new System.Drawing.Point(551, 29);
            this.btnPesquisarPorTel.Name = "btnPesquisarPorTel";
            this.btnPesquisarPorTel.Size = new System.Drawing.Size(81, 43);
            this.btnPesquisarPorTel.TabIndex = 35;
            this.btnPesquisarPorTel.Text = "Pesquisar";
            this.btnPesquisarPorTel.UseVisualStyleBackColor = false;
            this.btnPesquisarPorTel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 530);
            this.Controls.Add(this.btnPesquisarPorTel);
            this.Controls.Add(this.lblTelPrinPesquisa);
            this.Controls.Add(this.tbPesquisarTelefone);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dataGrigCliente);
            this.Controls.Add(this.btnConsultarCrudCliente);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnExibirCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrigCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarCrudCliente;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnExibirCliente;
        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.MaskedTextBox tbPesquisarTelefone;
        private System.Windows.Forms.Label lblTelPrinPesquisa;
        private System.Windows.Forms.Button btnPesquisarPorTel;
        public System.Windows.Forms.DataGridView dataGrigCliente;
    }
}