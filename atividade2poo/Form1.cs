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
    public partial class frmsoma : Form
    {
        public frmsoma()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtela1 frmtela = new frmtela1();
            frmtela.Show();
        }

        private void txtdistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double distancia, premio;
            distancia = Convert.ToDouble(txtdistancia.Text);
            if(distancia < 800)
            {
                premio = 5000;
            }
            else{
                if(distancia > 800 && distancia < 1500)
                {
                    premio = 10000;
                }
                else{
                     premio = 15000;
                }
            }
            txtpremio.Text = premio.ToString();            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdistancia.Clear();
            txtpremio.Clear();
            txtdistancia.Focus();
        }
    }
}
