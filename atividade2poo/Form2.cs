﻿using System;
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
    public partial class frmtela1 : Form
    {
        public frmtela1()
        {
            InitializeComponent();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsoma frmtela1 = new frmsoma();
            frmtela1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmtabela tela3 = new Frmtabela();
            tela3.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 tela2 = new Form4();
            tela2.Show();
        }
    }
}
