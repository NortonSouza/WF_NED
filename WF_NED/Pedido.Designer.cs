namespace WF_NED {
    partial class Pedido {
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
            this.btnFechar = new System.Windows.Forms.Label();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.dataGrigCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultarCrudCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnExibirCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrigCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(908, -25);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(17, 17);
            this.btnFechar.TabIndex = 39;
            this.btnFechar.Text = "X";
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnEditarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCli.FlatAppearance.BorderSize = 0;
            this.btnEditarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCli.ForeColor = System.Drawing.Color.White;
            this.btnEditarCli.Location = new System.Drawing.Point(131, 25);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(113, 50);
            this.btnEditarCli.TabIndex = 38;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.UseVisualStyleBackColor = false;
            // 
            // dataGrigCliente
            // 
            this.dataGrigCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrigCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.dataGrigCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrigCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrigCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrigCliente.Location = new System.Drawing.Point(12, 91);
            this.dataGrigCliente.Name = "dataGrigCliente";
            this.dataGrigCliente.Size = new System.Drawing.Size(916, 427);
            this.dataGrigCliente.TabIndex = 34;
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
            this.btnConsultarCrudCliente.TabIndex = 36;
            this.btnConsultarCrudCliente.Text = "Consultar";
            this.btnConsultarCrudCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCrudCliente.Click += new System.EventHandler(this.btnConsultarCrudCliente_Click);
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
            this.btnExcluirCliente.Location = new System.Drawing.Point(792, 25);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(113, 50);
            this.btnExcluirCliente.TabIndex = 37;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
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
            this.btnExibirCliente.TabIndex = 35;
            this.btnExibirCliente.Text = "Exibir";
            this.btnExibirCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(911, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "X";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEditarCli);
            this.Controls.Add(this.dataGrigCliente);
            this.Controls.Add(this.btnConsultarCrudCliente);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnExibirCliente);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrigCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.DataGridView dataGrigCliente;
        private System.Windows.Forms.Button btnConsultarCrudCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnExibirCliente;
        private System.Windows.Forms.Label label1;
    }
}