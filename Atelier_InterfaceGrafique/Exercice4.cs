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
    public partial class Exercice4: Form
    {
        int n1, n2, n3, min, produit, moy, max, s ;
        public Exercice4()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            n1 = int.Parse(nb1.Text);
            n2 = int.Parse(nb2.Text);
            n3 = int.Parse(nb3.Text);

            
            s = n1 + n2 + n3;
            produit = n1 * n2 * n3;
            moy = s / 3;
            min = Math.Min(n1, Math.Min(n2, n3));
            max = Math.Max(n1, Math.Max(n2, n3));

            
            maxi.Text = max.ToString();
            mini.Text = min.ToString();
            som.Text = s.ToString();
            prod.Text = produit.ToString();
            moyen.Text = moy.ToString();
        
        }

        private void moyen_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void prod_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void som_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mini_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bienvenue bienvenue = new Bienvenue();
            this.Hide();
            bienvenue.Show();
        }

        private void maxi_TextChanged(object sender, EventArgs e)
        {
            n1 = int.Parse(nb1.Text);
            n2 = int.Parse(nb2.Text);
            n3 = int.Parse(nb3.Text);
            max = Math.Max(n1, Math.Max(n2, n3));

        }
    }
}
