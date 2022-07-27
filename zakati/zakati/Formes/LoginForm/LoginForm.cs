using Bunifu.Framework.UI;
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

namespace zakati.Formes.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username_box.BackColor = Color.White;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password_box.BackColor = Color.White;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_bx_Click(object sender, EventArgs e)
        {
            save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_Popup(object sender, PopupEventArgs e)
        {

        }

        private void username_box_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                //this.password_box.SelectAll();
                //password_box.Focus();
                Key(password_box);
            }
           else if (e.KeyCode == Keys.Enter)
            {
                //this.password_box.SelectAll();
                // password_box.Focus();
                Key(password_box);
            }
        }
        public void Key(TextBox bn)
        {
            bn.Select();
            bn.Focus();
        }

        private void password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                //this.password_box.SelectAll();
                //password_box.Focus();
                Login_bx.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //this.password_box.SelectAll();
                // password_box.Focus();
                save();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Key(username_box);
            }
        }
        public void save()
        { 
           if(username_box.Text =="" || password_box.Text =="")
            {
                if(username_box.Text=="")
                {
                    Key(username_box);

                 }
                else
                {
                    Key(password_box);
                }

            }
            else
            {
                if (shared.db.utilisateur.Local.Any(a => a.nom == username_box.Text && a.Password == password_box.Text) == true)
                {
                    this.Hide();
                    Pr.Pr p = new Pr.Pr();
                    p.ShowDialog();
                }
                else if(shared.db.utilisateur.Local.Any(a => a.nom == username_box.Text) == true)
                {
                    password_box.BackColor = Color.Red;
                    Key(password_box);


                }
                else
                {
                    username_box.BackColor = Color.Red;
                    Key(username_box);

                }
            }
        
        }
    }
}
