using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zakati.Classes;

namespace zakati.Formes.UserForm
{
    public partial class UserManagmanet : Form
    {
        public UserManagmanet()
        {
            InitializeComponent();
        }
        double id = 0;
        public void load()
        {
            try
            {
                gridControl1.DataSource = shared.db.utilisateur.ToList();

            }
            catch
            {

            }
        }
        public void add()
        {
            try
            {
                Formes.UserForm.adduserf add = new adduserf();
                add.ShowDialog();
                load();
            }
            catch
            {

            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
       

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //add
            add();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            delete();
            
        }
     
        public void edit()
        {

        }

        public void delete()
        {
            if (id!=0)
            {
              
                try
                {
                    var us = shared.db.utilisateur.First(a => a.id == id);
                    shared.db.utilisateur.Remove(us);
                    shared.db.SaveChanges();
                    id = 0;
                    load();

                }
                catch
                {

                }
            }
        }

        private void UserManagmanet_Load(object sender, EventArgs e)
        {
            load();
        }

        private void refresh_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void edit_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edit();
        }

        private void suprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id = double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"id").ToString());
            }
            catch
                {

            }
        }
    }
}
