using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_InterfaceGrafique
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }
        double poid;
        double taille;
        double imc;
        string basePath = @"C:\Users\sakhe\source\repos\FawziSakher\Atelier_InterfaceGrafique\Atelier_InterfaceGrafique\Images"; // Remplacez par le chemin de votre image
        private void FormIMC_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bienvenue bienvenue = new Bienvenue();
            this.Hide();
            bienvenue.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputpoid.Text = inputtaille.Text = resultatIMC.Text = resultatetat.Text = "";
            string imagename = "youretat.jpg";
            string fullPath = Path.Combine(basePath, imagename);
            if (File.Exists(fullPath))
                pictureBox1.Image = Image.FromFile(fullPath);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputpoid.Text) || string.IsNullOrWhiteSpace(inputtaille.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!double.TryParse(inputpoid.Text, out poid) || !double.TryParse(inputtaille.Text, out taille))
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides.");
                return;
            }

            if (taille <= 0 || poid <= 20)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides (taille > 0 et poids > 20).");
                return;
            }


            imc = poid / ((taille / 100) * (taille / 100));
            resultatIMC.Text = imc.ToString("0.00"); // formatage avec 2 décimales

            if (imc < 18.5)
            {
                resultatetat.Text = "Maigre";
                string imagename = "maigre.jpg"; // Nom de l'image pour le poids maigre
                string fullPath = Path.Combine(basePath, imagename);
                if (File.Exists(fullPath))
                    pictureBox1.Image = Image.FromFile(fullPath);
            }
            else if (imc >= 18.5 && imc < 25)
            {
                resultatetat.Text = "Normal";
                string imagename = "normal.jpg"; // Nom de l'image pour le poids normal
                string fullPath = Path.Combine(basePath, imagename);
                if (File.Exists(fullPath))
                    pictureBox1.Image = Image.FromFile(fullPath);
            }
            else if (imc >= 25 && imc < 30)
            {
                resultatetat.Text = "Surpoids";
                string imagename = "surpoid.jpg"; // Nom de l'image pour le surpoids
                string fullPath = Path.Combine(basePath, imagename);
                if (File.Exists(fullPath))
                    pictureBox1.Image = Image.FromFile(fullPath);
            }
            else
            {
                resultatetat.Text = "Obésité";
                string imagename = "obésité.jpg"; // Nom de l'image pour l'obésité
                string fullPath = Path.Combine(basePath, imagename);
                if (File.Exists(fullPath))
                    pictureBox1.Image = Image.FromFile(fullPath);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

