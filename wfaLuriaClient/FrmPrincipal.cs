using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfaLuriaBHClient
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult _respostaUsuario = MessageBox.Show("Confirma a saída da aplicação?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (_respostaUsuario != DialogResult.Yes);
                
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsFuncionario frmconsFuncionario = new FrmConsFuncionario();
            frmconsFuncionario.Show();
        }
    }
}
