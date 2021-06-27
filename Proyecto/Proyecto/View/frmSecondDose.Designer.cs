
namespace Proyecto.View
{
    partial class frmSecondDose
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
            this.txtScndDse_dui = new System.Windows.Forms.TextBox();
            this.btnScndDse_Verify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScndDse_Info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScndDse_dui
            // 
            this.txtScndDse_dui.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScndDse_dui.Location = new System.Drawing.Point(75, 14);
            this.txtScndDse_dui.Name = "txtScndDse_dui";
            this.txtScndDse_dui.Size = new System.Drawing.Size(201, 29);
            this.txtScndDse_dui.TabIndex = 0;
            // 
            // btnScndDse_Verify
            // 
            this.btnScndDse_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScndDse_Verify.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScndDse_Verify.Location = new System.Drawing.Point(55, 162);
            this.btnScndDse_Verify.Name = "btnScndDse_Verify";
            this.btnScndDse_Verify.Size = new System.Drawing.Size(140, 61);
            this.btnScndDse_Verify.TabIndex = 1;
            this.btnScndDse_Verify.Text = "Verificar";
            this.btnScndDse_Verify.UseVisualStyleBackColor = true;
            this.btnScndDse_Verify.Click += new System.EventHandler(this.btnScndDse_Verify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUI:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtScndDse_dui);
            this.panel1.Location = new System.Drawing.Point(55, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 58);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese DUI para verificar su segunda dosis:";
            // 
            // lblScndDse_Info
            // 
            this.lblScndDse_Info.AutoSize = true;
            this.lblScndDse_Info.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScndDse_Info.Location = new System.Drawing.Point(55, 292);
            this.lblScndDse_Info.Name = "lblScndDse_Info";
            this.lblScndDse_Info.Size = new System.Drawing.Size(0, 25);
            this.lblScndDse_Info.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._1039373;
            this.pictureBox1.Location = new System.Drawing.Point(489, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.logo_covid__1_;
            this.pictureBox2.Location = new System.Drawing.Point(434, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmSecondDose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScndDse_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScndDse_Verify);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSecondDose";
            this.Text = "frmSecondDose";
            this.Load += new System.EventHandler(this.frmSecondDose_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScndDse_dui;
        private System.Windows.Forms.Button btnScndDse_Verify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScndDse_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}