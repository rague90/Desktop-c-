using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;

namespace maintenance_eptr
{
    public partial class frm_user : DevExpress.XtraEditors.XtraForm

    {
        static string sql = "Data Source =data.db ; Version= 3;";
        SQLiteConnection con = new SQLiteConnection(sql);
        //    private string sql = "Data Source =dbsqlite.db ; Version= 3;";
        /// private  SQLiteConnection con = new SQLiteConnection(sql);
        public frm_user()
        {
            InitializeComponent();
        }

        private void frm_user_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            
          if(DB.con.State == ConnectionState.Closed)
            {
                DB.con.Open();
                string qury = "SELECT * from users where user ='"+txt_Name.Text+"' and password= '"+txt_password.Text+"' ";
                SQLiteCommand cmd = new SQLiteCommand(qury, DB.con);
                  //int reslultat =  Convert.ToInt32(cmd.ExecuteScalar());
                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0) {
                    MessageBox.Show("hello"+dt.Rows[0][2]);
                    this.Hide();
                    var frm = Application.OpenForms["Main"] as Main;
                    frm.btn_mat.Enabled = true;
                    frm.btn_famille.Enabled = true;
                    frm.btn_consultation.Enabled = true;
                    frm.btn_intervention.Enabled = true;
                    frm.btn_operation.Enabled = true;
                    frm.btn_decon.Enabled = true;
                    frm.btn_affectation.Enabled = true;
                    frm.btn_conn.Enabled = false;

                  }
                else
                {
                    MessageBox.Show("تاكد من الدخول");
                    txt_Name.Clear();
                    txt_password.Clear();
                    txt_Name.Focus();
                    DB.con.Close();

                }
                DB.con.Close();


               /* if (reslultat > 0)
                {
                    MessageBox.Show("تم الدخول بنجاح");


                }else
                {
                    MessageBox.Show("تاكد من الدخول");
                    txt_Name.Clear();
                    txt_password.Clear();
                    txt_Name.Focus();
                    DB.con.Close();
                }*/
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}