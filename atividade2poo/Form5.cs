using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade2poo
{
    public partial class Frmtabela : Form
    {
        public Frmtabela()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double idade, salarioB, abono, salarioL = 0;
            string sexo, nome;
            idade = Convert.ToDouble(txtidade.Text);
            salarioB = Convert.ToDouble(txtsalarioB.Text);
            sexo = txtsexo.Text;
            nome = txtnome.Text;
            abono = 0;
            if (sexo == "masculino" || sexo == "Masculino"){ 
            if (idade >= 30){
                    salarioL = salarioB - 100;
                    abono = 100;

            }
            else{
                    salarioL = salarioB - 80;
                    abono = 80;

                }
            }
            else if (sexo == "feminino" || sexo == "Feminino"){
                if (idade >= 30){
                    salarioL = salarioB - 200;
                    abono = 200;
                }
                else{
                    salarioL = salarioB - 50;
                    abono = 50;
                }
            }
            txtnomeR.Text = nome;
            txtidadeR.Text = idade.ToString();
            txtabono.Text = abono.ToString();
            txtsalarioL.Text = salarioL.ToString();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtela1 frmtela = new frmtela1();
            frmtela.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtabono.Clear();
            txtsalarioL.Clear();
            txtidadeR.Clear();
            txtidade.Clear();
            txtnomeR.Clear();
            txtnome.Clear();
            txtsalarioB.Clear();
            txtsexo.Clear();
            txtsexo.Focus();
        }
    }
}
