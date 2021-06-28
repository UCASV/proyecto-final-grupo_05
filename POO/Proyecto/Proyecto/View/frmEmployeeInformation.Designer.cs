namespace Proyecto.View
{
    partial class frmEmployeeInformation
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
            this.dgvEmployeed = new System.Windows.Forms.DataGridView();
            this.textID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeed
            // 
            this.dgvEmployeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textID,
            this.txtNombre,
            this.txtEmail,
            this.txtdirection,
            this.txtCargo});
            this.dgvEmployeed.Location = new System.Drawing.Point(61, 102);
            this.dgvEmployeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployeed.Name = "dgvEmployeed";
            this.dgvEmployeed.RowHeadersWidth = 51;
            this.dgvEmployeed.RowTemplate.Height = 29;
            this.dgvEmployeed.Size = new System.Drawing.Size(684, 275);
            this.dgvEmployeed.TabIndex = 0;
            // 
            // textID
            // 
            this.textID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.textID.HeaderText = "Identificador";
            this.textID.Name = "textID";
            this.textID.Width = 99;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Width = 76;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtEmail.HeaderText = "Correo";
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Width = 68;
            // 
            // txtdirection
            // 
            this.txtdirection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtdirection.HeaderText = "Dirección";
            this.txtdirection.Name = "txtdirection";
            this.txtdirection.Width = 82;
            // 
            // txtCargo
            // 
            this.txtCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtCargo.HeaderText = "Cargo";
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Width = 64;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportPDF.Image = global::Proyecto.Properties.Resources.ico_pdf;
            this.btnExportPDF.Location = new System.Drawing.Point(571, 392);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(174, 71);
            this.btnExportPDF.TabIndex = 5;
            this.btnExportPDF.Text = "Generar PDF";
            this.btnExportPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 46);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.img_employee;
            this.pictureBox1.Location = new System.Drawing.Point(584, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de empleados";
            // 
            // frmEmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.dgvEmployeed);
            this.Name = "frmEmployeeInformation";
            this.Text = "frmEmployeeInformation";
            this.Load += new System.EventHandler(this.frmEmployeeInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeed;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCargo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}