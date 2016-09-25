namespace WinForms
{
    partial class frmMENU
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnPostre = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(73, 70);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(127, 23);
            this.btnComida.TabIndex = 1;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnPostre
            // 
            this.btnPostre.Location = new System.Drawing.Point(73, 115);
            this.btnPostre.Name = "btnPostre";
            this.btnPostre.Size = new System.Drawing.Size(127, 23);
            this.btnPostre.TabIndex = 3;
            this.btnPostre.Text = "Postres";
            this.btnPostre.UseVisualStyleBackColor = true;
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(73, 162);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(127, 23);
            this.btnBebidas.TabIndex = 4;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(99, 211);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnPostre);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.label1);
            this.Name = "frmMENU";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnPostre;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnSalir;
    }
}