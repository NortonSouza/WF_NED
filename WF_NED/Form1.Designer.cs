namespace WF_NED {
    partial class Form1 {
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
            this.pnlMenuLeft = new System.Windows.Forms.Panel();
            this.btnCLI = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbExpandir = new System.Windows.Forms.PictureBox();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuLeft.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLeft
            // 
            this.pnlMenuLeft.AllowDrop = true;
            this.pnlMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.pnlMenuLeft.Controls.Add(this.label1);
            this.pnlMenuLeft.Controls.Add(this.btnCLI);
            this.pnlMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLeft.Name = "pnlMenuLeft";
            this.pnlMenuLeft.Size = new System.Drawing.Size(79, 496);
            this.pnlMenuLeft.TabIndex = 0;
            // 
            // btnCLI
            // 
            this.btnCLI.BackColor = System.Drawing.Color.Transparent;
            this.btnCLI.BackgroundImage = global::WF_NED.Properties.Resources.administrator_male_40px;
            this.btnCLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCLI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCLI.FlatAppearance.BorderSize = 0;
            this.btnCLI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.btnCLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLI.Location = new System.Drawing.Point(0, 0);
            this.btnCLI.Name = "btnCLI";
            this.btnCLI.Size = new System.Drawing.Size(79, 69);
            this.btnCLI.TabIndex = 3;
            this.btnCLI.UseVisualStyleBackColor = false;
            this.btnCLI.Click += new System.EventHandler(this.btnCLI_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSuperior.Controls.Add(this.pbMin);
            this.pnlSuperior.Controls.Add(this.pbMinimizar);
            this.pnlSuperior.Controls.Add(this.pbExpandir);
            this.pnlSuperior.Controls.Add(this.pbFechar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(79, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(773, 50);
            this.pnlSuperior.TabIndex = 22;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // pbMin
            // 
            this.pbMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMin.Image = global::WF_NED.Properties.Resources.xbox_windows_32px;
            this.pbMin.Location = new System.Drawing.Point(691, 3);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(32, 32);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMin.TabIndex = 3;
            this.pbMin.TabStop = false;
            this.pbMin.Visible = false;
            this.pbMin.Click += new System.EventHandler(this.pbMin_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::WF_NED.Properties.Resources.minus_32px;
            this.pbMinimizar.Location = new System.Drawing.Point(653, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbExpandir
            // 
            this.pbExpandir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpandir.Image = global::WF_NED.Properties.Resources.xbox_windows_32px;
            this.pbExpandir.Location = new System.Drawing.Point(691, 3);
            this.pbExpandir.Name = "pbExpandir";
            this.pbExpandir.Size = new System.Drawing.Size(32, 32);
            this.pbExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExpandir.TabIndex = 1;
            this.pbExpandir.TabStop = false;
            this.pbExpandir.Click += new System.EventHandler(this.pbExpandir_Click);
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = global::WF_NED.Properties.Resources.macos_close_32px;
            this.pbFechar.Location = new System.Drawing.Point(729, 3);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(32, 32);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFechar.TabIndex = 0;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCentral.BackgroundImage = global::WF_NED.Properties.Resources.WhatsApp_Image_2020_01_25_at_13_04_08;
            this.pnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCentral.Location = new System.Drawing.Point(79, 50);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(773, 434);
            this.pnlCentral.TabIndex = 23;
            this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCentral_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(852, 496);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlMenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(852, 496);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenuLeft.ResumeLayout(false);
            this.pnlMenuLeft.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLeft;
        private System.Windows.Forms.Button btnCLI;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.PictureBox pbExpandir;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMin;
        public System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label label1;
    }
}

