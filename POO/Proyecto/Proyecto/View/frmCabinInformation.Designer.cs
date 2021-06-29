namespace Proyecto.View
{
    partial class frmCabinInformation
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
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtdirection,
            this.txtphone,
            this.txtname,
            this.txtemail});
            this.dgvInformation.Location = new System.Drawing.Point(59, 126);
            this.dgvInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersWidth = 51;
            this.dgvInformation.RowTemplate.Height = 29;
            this.dgvInformation.Size = new System.Drawing.Size(688, 306);
            this.dgvInformation.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.Width = 43;
            // 
            // txtdirection
            // 
            this.txtdirection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtdirection.HeaderText = "Dirección";
            this.txtdirection.Name = "txtdirection";
            this.txtdirection.Width = 82;
            // 
            // txtphone
            // 
            this.txtphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtphone.HeaderText = "Telefono";
            this.txtphone.Name = "txtphone";
            this.txtphone.Width = 77;
            // 
            // txtname
            // 
            this.txtname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtname.HeaderText = "Correo";
            this.txtname.Name = "txtname";
            this.txtname.Width = 68;
            // 
            // txtemail
            // 
            this.txtemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.txtemail.HeaderText = "Encargado";
            this.txtemail.Name = "txtemail";
            this.txtemail.Width = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de cabinas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.img_frmCabin;
            this.pictureBox1.Location = new System.Drawing.Point(574, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCabinInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInformation);
            this.Name = "frmCabinInformation";
            this.Text = "frmCabinInformation";
            this.Load += new System.EventHandler(this.frmCabinInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}