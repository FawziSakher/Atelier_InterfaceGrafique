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
    public partial class Bienvenue: Form
    {
        public Bienvenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculatrice calculatrice = new Calculatrice();
            this.Hide();
            calculatrice.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification();
            this.Hide();
            authentification.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercice4 exercice4 = new Exercice4();
            this.Hide();
            exercice4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercice2 exercice2 = new Exercice2();
            this.Hide();
            exercice2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercice3 exercice3 = new Exercice3();
            this.Hide();
            exercice3.Show();
        }

        private void Bienvenue_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormIMC formIMC = new FormIMC();
            this.Hide();
            formIMC.Show();
        }
    }
}
