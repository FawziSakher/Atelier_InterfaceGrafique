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
    public partial class Exercice3: Form
    {
        public Exercice3()
        {
            InitializeComponent();
        }
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(NB.Text);
            if (n % 2 == 0)
            {
                res.Text = $"{n} est un nombre pair";
            }
            else
            {
                res.Text = $"{n} est un nombre impair";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bienvenue bienvenue = new Bienvenue();
            this.Hide();
            bienvenue.Show();
        }
    }
}
