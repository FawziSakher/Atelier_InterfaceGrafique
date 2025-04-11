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
    public partial class Authentification: Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (log.Text == "fawzi" && mdp.Text == "admin")
            {
                this.Hide();
                Bienvenue bienvenue = new Bienvenue();
                bienvenue.Show();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect");
            }
        }

        private void modification_Click(object sender, EventArgs e)
        {
            log.Text = "";
            mdp.Text = "";
        }

        private void annulation_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
