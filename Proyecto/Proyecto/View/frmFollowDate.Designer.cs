
namespace Proyecto.View
{
    partial class frmFollowDate
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
            this.btnExportFollowDate = new System.Windows.Forms.Button();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportFollowDate
            // 
            this.btnExportFollowDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFollowDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportFollowDate.Image = global::Proyecto.Properties.Resources.ico_pdf;
            this.btnExportFollowDate.Location = new System.Drawing.Point(454, 381);
            this.btnExportFollowDate.Name = "btnExportFollowDate";
            this.btnExportFollowDate.Size = new System.Drawing.Size(241, 75);
            this.btnExportFollowDate.TabIndex = 17;
            this.btnExportFollowDate.Text = "     Exportar Datos";
            this.btnExportFollowDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportFollowDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFollowDate.UseVisualStyleBackColor = true;
            this.btnExportFollowDate.Click += new System.EventHandler(this.btnExportFollowDate_Click);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppointment.Location = new System.Drawing.Point(248, 91);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(89, 35);
            this.lblAppointment.TabIndex = 18;
            this.lblAppointment.Text = "Citas";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(212, 211);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(248, 23);
            this.txtDui.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese DUI:";
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Image = global::Proyecto.Properties.Resources.ico_verification;
            this.btnCheck.Location = new System.Drawing.Point(67, 381);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(241, 75);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Verificar";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.img_list;
            this.pictureBox1.Location = new System.Drawing.Point(493, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmFollowDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnExportFollowDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFollowDate";
            this.Text = "frmFollowDate";
            this.Load += new System.EventHandler(this.frmFollowDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportFollowDate;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}