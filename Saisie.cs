using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stagaire;

namespace Gestion_de_stagaires
{
    public partial class Saisie : Form
    {
        public Saisie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("sonner le numero");
                textBox1.Focus();
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("donner le prenom");
                textBox2.Focus();
            }
            else if(textBox3.Text=="")
            {
                MessageBox.Show("donner le nom");
                textBox3.Focus();
            }
            else
            {
                Stagaire st = new Stagaire(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text,textBox4.Text);
                ListStagairs.list_st.Add(st);
                MessageBox.Show("engregistrer");
                foreach(Control c in this .Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
                textBox1.Focus();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsNumber(c))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
