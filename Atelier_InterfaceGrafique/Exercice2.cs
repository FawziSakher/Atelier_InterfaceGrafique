using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_InterfaceGrafique
{
    public partial class Exercice2: Form
    {
        public Exercice2()
        {
            InitializeComponent();
        }
        int n1, n2;

        private void res_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           res.Text = (n1 + n2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bienvenue bienvenue = new Bienvenue();
            this.Hide();
            bienvenue.Show();
        }

        private void NB2_TextChanged(object sender, EventArgs e)
        {
            n2 = int.Parse(NB2.Text);
        }

        private void NB1_TextChanged(object sender, EventArgs e)
        {
            n1 = int.Parse(NB1.Text);
        }
    }
}
