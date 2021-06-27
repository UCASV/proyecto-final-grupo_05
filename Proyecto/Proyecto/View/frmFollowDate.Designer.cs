
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFollowDate));
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
            this.btnExportFollowDate.Image = global::Proyecto.Properties.Resources.ico_pdf1;
            this.btnExportFollowDate.Location = new System.Drawing.Point(519, 508);
            this.btnExportFollowDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportFollowDate.Name = "btnExportFollowDate";
            this.btnExportFollowDate.Size = new System.Drawing.Size(275, 100);
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
            this.lblAppointment.Location = new System.Drawing.Point(284, 121);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(110, 44);
            this.lblAppointment.TabIndex = 18;
            this.lblAppointment.Text = "Citas";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(242, 281);
            this.txtDui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(283, 27);
            this.txtDui.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese DUI:";
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Image = global::Proyecto.Properties.Resources.Circle_icons_check_svg__2_;
            this.btnCheck.Location = new System.Drawing.Point(77, 508);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(275, 100);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Verificar";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.listado_123;
            this.pictureBox1.Location = new System.Drawing.Point(563, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmFollowDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnExportFollowDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFollowDate";
            this.Text = "Vacuna Covid-19: Seguimiento de Cita";
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