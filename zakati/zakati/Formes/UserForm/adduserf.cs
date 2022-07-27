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
    public partial class adduserf : Form
    {
        public adduserf()
        {
            InitializeComponent();
        }
        public bool test = true;
        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zakateDataSet);

        }

        private void adduserf_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'zakateDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.zakateDataSet.utilisateur);

        }

        private void nomTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        

        private void nomTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
                    }

        private void nomTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                key(passwordTextBox);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                key(passwordTextBox);
            }
        }
        public void key(TextBox t)
        {
            t.SelectAll();
            t.Focus();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adduserf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(test ==true)
            {
                Application.Exit();
            }
          
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                key(phoneTextBox);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                key(phoneTextBox);
            }
            else if(e.KeyCode == Keys.Up)
            {
                key(nomTextBox);
            }
        }

        private void ADD_bx_Click(object sender, EventArgs e)
        {
            if(nomTextBox.Text=="" || passwordTextBox.Text=="")
            {
                if(nomTextBox.Text=="" )
                {
                    key(nomTextBox);

                }
                else
                {
                    key(passwordTextBox);
                }
            }
            else
            {
                try
                {
                    BaseDeDonnees.utilisateur us = new BaseDeDonnees.utilisateur();
                    us.nom = nomTextBox.Text;
                    us.Password = passwordTextBox.Text;
                    try
                    {
                        us.phone = double.Parse(phoneTextBox.Text);

                    }
                    catch { }
                    us.Date = dateDateTimePicker.Value;
                    shared.db.utilisateur.Add(us);
                    shared.db.SaveChanges();
                   
                    if(shared.db.utilisateur.Count()==1)
                    {
                        this.Hide();
                        Pr.Pr p = new Pr.Pr();
                        p.ShowDialog();
                    }
                    else
                    {
                        Close();
                    }
                }
                catch
                {

                }

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (test == true)
            {
                Application.Exit();
            }
        }
    }
}
