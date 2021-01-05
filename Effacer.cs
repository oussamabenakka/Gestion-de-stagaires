using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_stagaires
{
    public partial class Effacer : Form
    {
        public Effacer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(stagaire.Stagaire st in ListStagairs.list_st)
            { 
                if(int.Parse(comboBox1.SelectedItem.ToString())==st.Num)
                {
                    textBox2.Text = st.Groupe;
                    textBox3.Text = st.Prenom;
                    textBox4.Text = st.Nom;
                    DialogResult rep= MessageBox.Show("vous ête sur","",MessageBoxButtons.OK);
                    if(rep==DialogResult.OK)
                    {
                        ListStagairs.list_st.Remove(st);
                        break;
                    }
                    else
                    {
                        comboBox1.Focus();
                        break;
                    }
                }
            }
            MessageBox.Show("supprimer avec succès");
        }

        private void Effacer_Load(object sender, EventArgs e)
        {
            foreach(stagaire.Stagaire st in ListStagairs.list_st)
            {
                comboBox1.Items.Add(st.Num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
