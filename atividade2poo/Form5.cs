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
            double sexo, idade, nome, salarioB, abono, salarioL;
            idade = Convert.ToDouble(txtidade.Text);
            salarioB = Convert.ToDouble(txtsalarioB.Text);
            sexo = txtsexo;
            if (sexo == masculino || sexo == Masculino){ 
            if (idade >= 30){
                    salarioL = salarioB - 100;
                    abono = 100;

            }
            else{
                    salarioL = salarioB - 80;
                    abono = 80;

                }
            }

        }
    }
}
