using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenance_eptr
{
    public partial class FAMILLE : System.Windows.Forms.Form
    {
        Boolean ADD;
        public FAMILLE()
        {

            InitializeComponent();
            Methode use = new Methode();
            use.loadfamille();
            //load dsplay and value id combobox
            combo_fammille.DataSource = use.dt;
            combo_fammille.DisplayMember = "Code_Famille";
            combo_fammille.ValueMember = "ID_Famille";
        }

        private void FAMILLE_Load(object sender, EventArgs e)
        {
            Methode use = new Methode();
            grid_famille.DataSource = use.loadfamille();
            grid_sousfamille.DataSource = use.load_sousfamille();




        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void panel_sousfamille_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ADD == true)
            {
                Methode use = new Methode();
                use.insert_Famille(txt_codefamille.Text, txt_Designation.Text);
                //dataGridView1.DataSource = use.loadfromdb();
                grid_famille.DataSource = use.loadfamille();
                txt_codefamille.Clear();
                txt_Designation.Clear();
                txt_codefamille.Focus();
            }
            else
            {

                //update
            }
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            txt_codefamille.Clear();
            txt_Designation.Clear();
            txt_codefamille.Focus();
            ADD = true;
            btn_valider.Enabled = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ADD = false;
            btn_valider.Enabled = true;
        }

        private void combo_fammille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            txt_sousfamille.Clear();
            txt_dessousfami.Clear();
            txt_sousfamille.Focus();
            ADD = true;
            btn_savesousf.Enabled = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (ADD == true)
            {
                Methode use = new Methode();
                use.insert_SousFamille(txt_dessousfami.Text, txt_dessousfami.Text, combo_fammille.SelectedValue.ToString());
                grid_sousfamille.DataSource = use.load_sousfamille();
            }
            else
            { //update 
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ADD = false;
            btn_savesousf.Enabled = true;
        }
    }
}
