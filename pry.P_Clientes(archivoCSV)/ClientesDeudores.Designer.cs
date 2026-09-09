namespace pry.P_Clientes_archivoCSV_
{
    partial class ClientesDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesDeudores));
            this.dgvClientesD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromD = new System.Windows.Forms.Label();
            this.lblCantD = new System.Windows.Forms.Label();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.btnListarD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesD
            // 
            this.dgvClientesD.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvClientesD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientesD.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvClientesD.Location = new System.Drawing.Point(22, 16);
            this.dgvClientesD.Name = "dgvClientesD";
            this.dgvClientesD.Size = new System.Drawing.Size(443, 276);
            this.dgvClientesD.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lista de credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // lblPromD
            // 
            this.lblPromD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromD.Location = new System.Drawing.Point(300, 388);
            this.lblPromD.Name = "lblPromD";
            this.lblPromD.Size = new System.Drawing.Size(165, 23);
            this.lblPromD.TabIndex = 27;
            // 
            // lblCantD
            // 
            this.lblCantD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantD.Location = new System.Drawing.Point(300, 348);
            this.lblCantD.Name = "lblCantD";
            this.lblCantD.Size = new System.Drawing.Size(165, 23);
            this.lblCantD.TabIndex = 24;
            // 
            // lblTotalD
            // 
            this.lblTotalD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalD.Location = new System.Drawing.Point(300, 308);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(165, 23);
            this.lblTotalD.TabIndex = 23;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalDeuda.Location = new System.Drawing.Point(163, 307);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(0, 16);
            this.lblTotalDeuda.TabIndex = 22;
            // 
            // btnListarD
            // 
            this.btnListarD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnListarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarD.Location = new System.Drawing.Point(312, 430);
            this.btnListarD.Name = "btnListarD";
            this.btnListarD.Size = new System.Drawing.Size(153, 31);
            this.btnListarD.TabIndex = 21;
            this.btnListarD.Text = "Listar Deudores";
            this.btnListarD.UseVisualStyleBackColor = false;
            this.btnListarD.Click += new System.EventHandler(this.btnListarD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(141, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Promedio de deuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(136, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cantidad de clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(172, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total de deuda";
            // 
            // ClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvClientesD);
            this.Controls.Add(this.lblPromD);
            this.Controls.Add(this.lblCantD);
            this.Controls.Add(this.lblTotalD);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.btnListarD);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientesDeudores";
            this.Text = "ClientesDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPromD;
        private System.Windows.Forms.Label lblCantD;
        private System.Windows.Forms.Label lblTotalD;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Button btnListarD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}