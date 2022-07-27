using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zakati.Classes;

namespace zakati.Formes.SplashScreen
{
    public partial class FSC : Form
    {
        public FSC()
        {
            InitializeComponent();
            load();
        }
        
        public int calcul()
        {

        return 100/ 3;
        }

        public void load()
        { try
            {
                shared.db.utilisateur.Load();
                progressBar1.Value += calcul();
                shared.db.Client.Load();
                progressBar1.Value += calcul();
                shared.db.istifada.Load();
                progressBar1.Value += calcul();
                if(shared.db.utilisateur.Count()==0)
                {
                    this.Hide();
                    Formes.UserForm.adduserf ad = new UserForm.adduserf();
                    ad.test = true;
                    ad.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    this.Hide();
                    Formes.LoginForm.LoginForm add = new LoginForm.LoginForm();
            
                    add.ShowDialog();
                    Application.Exit();
                }
            }
            catch
            {



            }
        }
    }
}
