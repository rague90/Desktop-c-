using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maintenance_eptr
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {

            InitializeComponent();
                
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click_2(object sender, EventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem9_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem3_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem3_ItemClick_2(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            FAMILLE famille = new FAMILLE();
            famille.ShowDialog();
        }

        private void c_Click(object sender, EventArgs e)
        {
            frm_user login = new frm_user();
            login.ShowDialog();


        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            btn_mat.Expanded = false;
            btn_famille.Expanded = false;
            btn_consultation.Expanded = false;
            btn_intervention.Expanded = false;
            btn_operation.Expanded = false;
            btn_decon.Expanded = false;
            btn_affectation.Expanded = false;
          

            btn_mat.Enabled = false;
            btn_famille.Enabled = false;
            btn_consultation.Enabled = false;
            btn_intervention.Enabled = false;
            btn_operation.Enabled = false;
            btn_decon.Enabled = false;
            btn_affectation.Enabled = false;
            btn_conn.Enabled = true;
            btn_decon.Enabled = false;
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
