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
    public partial class Calculatrice: Form
    {
       
        public Calculatrice()
        {
            InitializeComponent();
        }
        double memo;
        char op;
        private void ecrire(string n)
        {
            if (res.Text == "0" || res.Text == "Division par zéro impossible")
            {
                res.Text = n;
            }
            else
                res.Text = res.Text + n;
        }
       private void operation(char p)
        {
            memo = double.Parse(res.Text);
            op = p;
            res.Text = "0";
        }
        private void zero_Click(object sender, EventArgs e)
        {
            ecrire("0");
        }
        private void un_Click(object sender, EventArgs e)
        {
            ecrire("1");
        }

        private void deux_Click(object sender, EventArgs e)
        {
            ecrire("2");
        }

        private void trois_Click(object sender, EventArgs e)
        {
            ecrire("3");
        }

        private void quatre_Click(object sender, EventArgs e)
        {
            ecrire("4");
        }

        private void cinq_Click(object sender, EventArgs e)
        {
            ecrire("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            ecrire("6");
        }

        private void sept_Click(object sender, EventArgs e)
        {
            ecrire("7");    
        }

        private void huit_Click(object sender, EventArgs e)
        {
            ecrire("8");    
        }

        private void neuf_Click(object sender, EventArgs e)
        {
            ecrire("9");
        }

        private void egale_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                memo = memo + double.Parse(res.Text);
                res.Text = memo.ToString();
            }
            else if (op == '-')
            {
                memo = memo - double.Parse(res.Text);
                res.Text = memo.ToString();
            }
            else if (op == '*')
            {
                memo = memo * double.Parse(res.Text);
                res.Text = memo.ToString();
            }
            else if (op == '/')
            {
                if (double.Parse(res.Text) == 0)
                {
                    res.Text = "Division par zéro impossible";
                    return;
                }
                else
                {
                    memo = memo / double.Parse(res.Text);
                    res.Text = memo.ToString();
                }
                
            }
            else if (op == '^')
            {
                memo = Math.Pow(memo, double.Parse(res.Text));
                res.Text = memo.ToString();
            }
        }

        private void acceuil_Click(object sender, EventArgs e)
        {
            Bienvenue bienvenue = new Bienvenue();
            this.Hide();
            bienvenue.Show();
        }

        private void plusoumoins_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(res.Text))*(-1);
            res.Text = memo.ToString();
        }

        private void unsur_Click(object sender, EventArgs e)
        {
            memo = 1/(double.Parse(res.Text));
            res.Text = memo.ToString();
        }

        private void aucarré_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(res.Text)),2);
            res.Text = memo.ToString();
        }

        private void racine_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt(double.Parse(res.Text));
            res.Text = memo.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operation('+');
        }

        private void moins_Click(object sender, EventArgs e)
        {
            operation('-');
        }

        private void fois_Click(object sender, EventArgs e)
        {
            operation('*');
        }

        private void division_Click(object sender, EventArgs e)
        {
            operation('/');
        }

        private void xexposanty_Click(object sender, EventArgs e)
        {
          operation('^');
        }

        private void vergulle_Click(object sender, EventArgs e)
        {
            if (res.Text.Contains(",") == false)
            {
                res.Text = res.Text + ",";
            }
        

        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            memo = double.Parse(res.Text);
            res.Text = "0";
        }

        private void Mmions_Click(object sender, EventArgs e)
        {
            res.Text = ((double.Parse(res.Text))- memo).ToString();
        }

        private void M_Click(object sender, EventArgs e)
        {
            res.Text = memo.ToString();
        }

        private void Mefface_Click(object sender, EventArgs e)
        {
            memo = 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            res.Text = "0";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            res.Text = "0";
        }

        private void retour_Click(object sender, EventArgs e)
        {
            res.Text = res.Text.Substring(0, res.Text.Length - 1);
            if (res.Text == "")
            {
                res.Text = "0";
            }
           
        }

        private void pourcentage_Click(object sender, EventArgs e)
        {
            memo = double.Parse(res.Text) / 100;
            res.Text = memo.ToString();
        }

        private void res_TextChanged(object sender, EventArgs e)
        {
            if (res.Text.Length > 16)
            {
                res.Font = new Font("Microsoft Sans Serif", 8);
            }
        }
    }
}
