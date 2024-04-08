namespace atividade2poo
{
    partial class Form4
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
            this.lblsalariof = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblcomissao = new System.Windows.Forms.Label();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.lblcarros = new System.Windows.Forms.Label();
            this.txtvendaT = new System.Windows.Forms.TextBox();
            this.lblvalorVendas = new System.Windows.Forms.Label();
            this.txtvalorT = new System.Windows.Forms.TextBox();
            this.lblsalarioS = new System.Windows.Forms.Label();
            this.txtsalarioS = new System.Windows.Forms.TextBox();
            this.lblsalarioFinal = new System.Windows.Forms.Label();
            this.txtsalarioF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblsalariof
            // 
            this.lblsalariof.AutoSize = true;
            this.lblsalariof.Location = new System.Drawing.Point(40, 37);
            this.lblsalariof.Name = "lblsalariof";
            this.lblsalariof.Size = new System.Drawing.Size(161, 13);
            this.lblsalariof.TabIndex = 0;
            this.lblsalariof.Text = "Digite o salário fixo do vendedor:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(207, 34);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 1;
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Location = new System.Drawing.Point(43, 70);
            this.lblcomissao.Name = "lblcomissao";
            this.lblcomissao.Size = new System.Drawing.Size(163, 13);
            this.lblcomissao.TabIndex = 2;
            this.lblcomissao.Text = "Digite a comissão fixa por venda:";
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(207, 70);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(100, 20);
            this.txtcomissao.TabIndex = 3;
            // 
            // lblcarros
            // 
            this.lblcarros.AutoSize = true;
            this.lblcarros.Location = new System.Drawing.Point(43, 104);
            this.lblcarros.Name = "lblcarros";
            this.lblcarros.Size = new System.Drawing.Size(177, 13);
            this.lblcarros.TabIndex = 4;
            this.lblcarros.Text = "Digite o número de carros vendidos:";
            // 
            // txtvendaT
            // 
            this.txtvendaT.Location = new System.Drawing.Point(227, 104);
            this.txtvendaT.Name = "txtvendaT";
            this.txtvendaT.Size = new System.Drawing.Size(100, 20);
            this.txtvendaT.TabIndex = 5;
            // 
            // lblvalorVendas
            // 
            this.lblvalorVendas.AutoSize = true;
            this.lblvalorVendas.Location = new System.Drawing.Point(43, 136);
            this.lblvalorVendas.Name = "lblvalorVendas";
            this.lblvalorVendas.Size = new System.Drawing.Size(153, 13);
            this.lblvalorVendas.TabIndex = 6;
            this.lblvalorVendas.Text = "Digite o valor total das vendas:";
            // 
            // txtvalorT
            // 
            this.txtvalorT.Location = new System.Drawing.Point(202, 136);
            this.txtvalorT.Name = "txtvalorT";
            this.txtvalorT.Size = new System.Drawing.Size(100, 20);
            this.txtvalorT.TabIndex = 7;
            // 
            // lblsalarioS
            // 
            this.lblsalarioS.AutoSize = true;
            this.lblsalarioS.Location = new System.Drawing.Point(40, 166);
            this.lblsalarioS.Name = "lblsalarioS";
            this.lblsalarioS.Size = new System.Drawing.Size(117, 13);
            this.lblsalarioS.TabIndex = 8;
            this.lblsalarioS.Text = "Salário final sem os 5%:";
            this.lblsalarioS.Click += new System.EventHandler(this.lblsalarioS_Click);
            // 
            // txtsalarioS
            // 
            this.txtsalarioS.Location = new System.Drawing.Point(163, 166);
            this.txtsalarioS.Name = "txtsalarioS";
            this.txtsalarioS.ReadOnly = true;
            this.txtsalarioS.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioS.TabIndex = 9;
            // 
            // lblsalarioFinal
            // 
            this.lblsalarioFinal.AutoSize = true;
            this.lblsalarioFinal.Location = new System.Drawing.Point(40, 205);
            this.lblsalarioFinal.Name = "lblsalarioFinal";
            this.lblsalarioFinal.Size = new System.Drawing.Size(118, 13);
            this.lblsalarioFinal.TabIndex = 10;
            this.lblsalarioFinal.Text = "Salário final com os 5%:";
            // 
            // txtsalarioF
            // 
            this.txtsalarioF.Location = new System.Drawing.Point(165, 205);
            this.txtsalarioF.Name = "txtsalarioF";
            this.txtsalarioF.ReadOnly = true;
            this.txtsalarioF.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioF.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsalarioF);
            this.Controls.Add(this.lblsalarioFinal);
            this.Controls.Add(this.txtsalarioS);
            this.Controls.Add(this.lblsalarioS);
            this.Controls.Add(this.txtvalorT);
            this.Controls.Add(this.lblvalorVendas);
            this.Controls.Add(this.txtvendaT);
            this.Controls.Add(this.lblcarros);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.lblcomissao);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalariof);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsalariof;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblcomissao;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.Label lblcarros;
        private System.Windows.Forms.TextBox txtvendaT;
        private System.Windows.Forms.Label lblvalorVendas;
        private System.Windows.Forms.TextBox txtvalorT;
        private System.Windows.Forms.Label lblsalarioS;
        private System.Windows.Forms.TextBox txtsalarioS;
        private System.Windows.Forms.Label lblsalarioFinal;
        private System.Windows.Forms.TextBox txtsalarioF;
    }
}