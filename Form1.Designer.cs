
namespace tds3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Button();
            this.lblMostra = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.AutoSize = true;
            this.txtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(357, 9);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(105, 16);
            this.txtFrase.TabIndex = 0;
            this.txtFrase.Text = "Digite uma frase";
            this.txtFrase.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(733, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblMostrar
            // 
            this.lblMostrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(334, 61);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(148, 31);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.Text = "Mostrar";
            this.lblMostrar.UseVisualStyleBackColor = true;
            this.lblMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMostra
            // 
            this.lblMostra.AutoSize = true;
            this.lblMostra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostra.Location = new System.Drawing.Point(217, 261);
            this.lblMostra.Name = "lblMostra";
            this.lblMostra.Size = new System.Drawing.Size(0, 23);
            this.lblMostra.TabIndex = 3;
            this.lblMostra.Click += new System.EventHandler(this.lblMostra_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Location = new System.Drawing.Point(334, 458);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(148, 29);
            this.btnCalculadora.TabIndex = 4;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(810, 499);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.lblMostra);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFrase);
            this.Name = "Form1";
            this.Text = "Meu primeiro ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFrase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button lblMostrar;
        private System.Windows.Forms.Label lblMostra;
        private System.Windows.Forms.Button btnCalculadora;
    }
}

