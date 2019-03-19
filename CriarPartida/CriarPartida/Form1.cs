using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace CriarPartida
{
    public partial class Form1 : Form
    {
        int salaID;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalaCriar_Click(object sender, EventArgs e)
        {
            salaID = Convert.ToInt32(Jogo.CriarPartida(txtSalaNome.Text, txtSalaSenha.Text));
            MessageBox.Show(salaID.ToString());
        }
    }
}
