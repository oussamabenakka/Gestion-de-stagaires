using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stagaire;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_de_stagaires
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Saisie";
            SlidPanel.Height = button1.Height;
            SlidPanel.Top = button1.Top;
            SlidPanel.Visible = true;
            Saisie s = new Saisie();
            s.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Effacer";
            SlidPanel.Height = button4.Height;
            SlidPanel.Top = button4.Top;
            SlidPanel.Visible = true;
            Effacer ef = new Effacer();
            ef.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Rechercher";
            SlidPanel.Height = button3.Height;
            SlidPanel.Top = button3.Top;
            SlidPanel.Visible = true;
            Rechercher rch = new Rechercher();
            rch.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Affichage";
            SlidPanel.Height = button8.Height;
            SlidPanel.Top = button8.Top;
            SlidPanel.Visible = true;
            Afficher aff = new Afficher();
            aff.Show();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Text = "";
            SlidPanel.Visible = false;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Saisie s = new Saisie();
            Effacer eff = new Effacer();
            Rechercher rch = new Rechercher();
            Afficher aff = new Afficher();
            s.Close();
            eff.Close();
            rch.Close();
            aff.Close();
            label1.Text = "";
            SlidPanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("Stagaire.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(F, ListStagairs.list_st);
            F.Close();
            MessageBox.Show("Sauvgaderder");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("Stagaire.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ListStagairs.list_st = (ArrayList)bf.Deserialize(F);
            MessageBox.Show("Restaurer");
        }
    }
}
