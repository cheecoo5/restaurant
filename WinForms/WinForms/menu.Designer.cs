namespace WinForms
{
    partial class menu
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
            this.btnComida = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnPostres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(70, 124);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(156, 43);
            this.btnComida.TabIndex = 0;
            this.btnComida.Text = "COMIDA";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(70, 84);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(156, 43);
            this.btnBebidas.TabIndex = 1;
            this.btnBebidas.Text = "BEBIDAS";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnPostres
            // 
            this.btnPostres.Location = new System.Drawing.Point(70, 164);
            this.btnPostres.Name = "btnPostres";
            this.btnPostres.Size = new System.Drawing.Size(156, 43);
            this.btnPostres.TabIndex = 2;
            this.btnPostres.Text = "POSTRES";
            this.btnPostres.UseVisualStyleBackColor = true;
            this.btnPostres.Click += new System.EventHandler(this.btnPostres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(111, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 271);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPostres);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnComida);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnPostres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}