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
    public partial class Rechercher : Form
    {
        public Rechercher()
        {
            InitializeComponent();
        }

        private void Rechercher_Load(object sender, EventArgs e)
        {
            foreach(stagaire.Stagaire st in ListStagairs.list_st)
            {
                comboBox1.Items.Add(st.Num);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(stagaire.Stagaire st in ListStagairs.list_st)
            {
                if (int.Parse(comboBox1.SelectedItem.ToString())==st.Num)
                {
                    textBox2.Text = st.Groupe;
                    textBox3.Text = st.Prenom;
                    textBox4.Text = st.Nom;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
