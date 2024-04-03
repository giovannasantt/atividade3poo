namespace atividade2poo
{
    partial class frmsoma
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
            this.btnsair = new System.Windows.Forms.Button();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.lbldistancia = new System.Windows.Forms.Label();
            this.lblpremio = new System.Windows.Forms.Label();
            this.txtpremio = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsair.Location = new System.Drawing.Point(194, 157);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Voltar";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(124, 45);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 20);
            this.txtdistancia.TabIndex = 1;
            this.txtdistancia.TextChanged += new System.EventHandler(this.txtdistancia_TextChanged);
            // 
            // lbldistancia
            // 
            this.lbldistancia.AutoSize = true;
            this.lbldistancia.Location = new System.Drawing.Point(13, 48);
            this.lbldistancia.Name = "lbldistancia";
            this.lbldistancia.Size = new System.Drawing.Size(105, 13);
            this.lbldistancia.TabIndex = 2;
            this.lbldistancia.Text = "Distância em metros:";
            // 
            // lblpremio
            // 
            this.lblpremio.AutoSize = true;
            this.lblpremio.Location = new System.Drawing.Point(13, 91);
            this.lblpremio.Name = "lblpremio";
            this.lblpremio.Size = new System.Drawing.Size(83, 13);
            this.lblpremio.TabIndex = 3;
            this.lblpremio.Text = "Valor do prêmio;";
            // 
            // txtpremio
            // 
            this.txtpremio.Location = new System.Drawing.Point(124, 88);
            this.txtpremio.Name = "txtpremio";
            this.txtpremio.ReadOnly = true;
            this.txtpremio.Size = new System.Drawing.Size(100, 20);
            this.txtpremio.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncalcular.Location = new System.Drawing.Point(12, 157);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Location = new System.Drawing.Point(104, 157);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmsoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpremio);
            this.Controls.Add(this.lblpremio);
            this.Controls.Add(this.lbldistancia);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.btnsair);
            this.Name = "frmsoma";
            this.Text = "Calculadora de distância";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.Label lbldistancia;
        private System.Windows.Forms.Label lblpremio;
        private System.Windows.Forms.TextBox txtpremio;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
    }
}

