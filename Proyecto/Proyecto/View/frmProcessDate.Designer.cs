
namespace Proyecto.View
{
    partial class frmProcessDate
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.nudIdentificator = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.clbDiseases = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Image = global::Proyecto.Properties.Resources.ico_user;
            this.btnRegister.Location = new System.Drawing.Point(515, 233);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(241, 75);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registrar Ciudadano";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del ciudadano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "DUI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(515, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(443, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero Identificador:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(99, 87);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(178, 23);
            this.txtDui.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(99, 185);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(315, 23);
            this.txtDirection.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(605, 87);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 23);
            this.txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.Img_Proceso_Cita;
            this.pictureBox1.Location = new System.Drawing.Point(304, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Image = global::Proyecto.Properties.Resources.ico_pdf1;
            this.btnExport.Location = new System.Drawing.Point(515, 329);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(241, 75);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "     Exportar Datos";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // nudIdentificator
            // 
            this.nudIdentificator.Location = new System.Drawing.Point(605, 172);
            this.nudIdentificator.Name = "nudIdentificator";
            this.nudIdentificator.Size = new System.Drawing.Size(135, 23);
            this.nudIdentificator.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(538, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Edad:";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(605, 130);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(137, 23);
            this.nudAge.TabIndex = 19;
            // 
            // clbDiseases
            // 
            this.clbDiseases.CheckOnClick = true;
            this.clbDiseases.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbDiseases.FormattingEnabled = true;
            this.clbDiseases.Items.AddRange(new object[] {
            "Diabetes M",
            "Hipertensión",
            "Cardiopatías",
            "Obesidad Morb",
            "Cáncer",
            "Insuficiencia Renal",
            "Ninguna"});
            this.clbDiseases.Location = new System.Drawing.Point(90, 311);
            this.clbDiseases.Name = "clbDiseases";
            this.clbDiseases.Size = new System.Drawing.Size(165, 151);
            this.clbDiseases.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Enfermedades Crónicas:";
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClean.Location = new System.Drawing.Point(515, 419);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(241, 52);
            this.btnClean.TabIndex = 22;
            this.btnClean.Text = "     Limpiar";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // frmProcessDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbDiseases);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudIdentificator);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProcessDate";
            this.Load += new System.EventHandler(this.frmProcessDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.NumericUpDown nudIdentificator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.CheckedListBox clbDiseases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClean;
    }
}