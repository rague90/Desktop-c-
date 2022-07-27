namespace maintenance_eptr
{
    partial class FAMILLE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAMILLE));
            this.panel_sousfamille = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_fammille = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dessousfami = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sousfamille = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_savesousf = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.grid_sousfamille = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel_famille = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Designation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codefamille = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_valider = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nouveau = new DevExpress.XtraEditors.SimpleButton();
            this.grid_famille = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel_sousfamille.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sousfamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel_famille.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_famille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sousfamille
            // 
            this.panel_sousfamille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_sousfamille.Controls.Add(this.groupBox4);
            this.panel_sousfamille.Controls.Add(this.groupBox3);
            this.panel_sousfamille.Controls.Add(this.grid_sousfamille);
            this.panel_sousfamille.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sousfamille.Location = new System.Drawing.Point(482, 0);
            this.panel_sousfamille.Name = "panel_sousfamille";
            this.panel_sousfamille.Size = new System.Drawing.Size(494, 622);
            this.panel_sousfamille.TabIndex = 2;
            this.panel_sousfamille.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sousfamille_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.combo_fammille);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_dessousfami);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_sousfamille);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 177);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 15;
            this.label5.Tag = "";
            this.label5.Text = "Code_Famille:";
            // 
            // combo_fammille
            // 
            this.combo_fammille.FormattingEnabled = true;
            this.combo_fammille.Location = new System.Drawing.Point(171, 36);
            this.combo_fammille.Name = "combo_fammille";
            this.combo_fammille.Size = new System.Drawing.Size(264, 32);
            this.combo_fammille.TabIndex = 14;
            this.combo_fammille.SelectedIndexChanged += new System.EventHandler(this.combo_fammille_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 13;
            this.label3.Tag = "";
            this.label3.Text = "Designation:";
            // 
            // txt_dessousfami
            // 
            this.txt_dessousfami.Location = new System.Drawing.Point(171, 127);
            this.txt_dessousfami.Name = "txt_dessousfami";
            this.txt_dessousfami.Size = new System.Drawing.Size(264, 29);
            this.txt_dessousfami.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 11;
            this.label4.Tag = "";
            this.label4.Text = "Sous_Famille:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_sousfamille
            // 
            this.txt_sousfamille.Location = new System.Drawing.Point(171, 80);
            this.txt_sousfamille.Name = "txt_sousfamille";
            this.txt_sousfamille.Size = new System.Drawing.Size(264, 29);
            this.txt_sousfamille.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Controls.Add(this.simpleButton5);
            this.groupBox3.Controls.Add(this.btn_savesousf);
            this.groupBox3.Controls.Add(this.simpleButton7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materiels";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(328, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 37);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Supprimer";
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(220, 28);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(102, 37);
            this.simpleButton5.TabIndex = 2;
            this.simpleButton5.Text = "Modefier";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btn_savesousf
            // 
            this.btn_savesousf.Enabled = false;
            this.btn_savesousf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.btn_savesousf.Location = new System.Drawing.Point(119, 28);
            this.btn_savesousf.Name = "btn_savesousf";
            this.btn_savesousf.Size = new System.Drawing.Size(95, 37);
            this.btn_savesousf.TabIndex = 1;
            this.btn_savesousf.Text = "Valider";
            this.btn_savesousf.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.simpleButton7.Location = new System.Drawing.Point(11, 28);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(102, 37);
            this.simpleButton7.TabIndex = 0;
            this.simpleButton7.Text = "Nouveau";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // grid_sousfamille
            // 
            this.grid_sousfamille.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_sousfamille.Location = new System.Drawing.Point(0, 288);
            this.grid_sousfamille.MainView = this.gridView2;
            this.grid_sousfamille.Name = "grid_sousfamille";
            this.grid_sousfamille.Size = new System.Drawing.Size(490, 330);
            this.grid_sousfamille.TabIndex = 2;
            this.grid_sousfamille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_sousfamille;
            this.gridView2.Name = "gridView2";
            // 
            // panel_famille
            // 
            this.panel_famille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_famille.Controls.Add(this.groupBox2);
            this.panel_famille.Controls.Add(this.groupBox1);
            this.panel_famille.Controls.Add(this.grid_famille);
            this.panel_famille.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_famille.Location = new System.Drawing.Point(0, 0);
            this.panel_famille.Name = "panel_famille";
            this.panel_famille.Size = new System.Drawing.Size(483, 622);
            this.panel_famille.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Designation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_codefamille);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 13;
            this.label2.Tag = "";
            this.label2.Text = "Designation:";
            // 
            // txt_Designation
            // 
            this.txt_Designation.Location = new System.Drawing.Point(171, 78);
            this.txt_Designation.Name = "txt_Designation";
            this.txt_Designation.Size = new System.Drawing.Size(264, 29);
            this.txt_Designation.TabIndex = 12;
            this.txt_Designation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 11;
            this.label1.Tag = "";
            this.label1.Text = "Code_Famille:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_codefamille
            // 
            this.txt_codefamille.Location = new System.Drawing.Point(171, 31);
            this.txt_codefamille.Name = "txt_codefamille";
            this.txt_codefamille.Size = new System.Drawing.Size(264, 29);
            this.txt_codefamille.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.btn_valider);
            this.groupBox1.Controls.Add(this.btn_nouveau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materiels";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(328, 28);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(107, 37);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Supprimer";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(220, 28);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(102, 37);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Modefier";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Enabled = false;
            this.btn_valider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_valider.ImageOptions.SvgImage")));
            this.btn_valider.Location = new System.Drawing.Point(119, 28);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(95, 37);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_nouveau.ImageOptions.SvgImage")));
            this.btn_nouveau.Location = new System.Drawing.Point(11, 28);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(102, 37);
            this.btn_nouveau.TabIndex = 0;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // grid_famille
            // 
            this.grid_famille.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_famille.Location = new System.Drawing.Point(0, 288);
            this.grid_famille.MainView = this.gridView1;
            this.grid_famille.Name = "grid_famille";
            this.grid_famille.Size = new System.Drawing.Size(479, 330);
            this.grid_famille.TabIndex = 1;
            this.grid_famille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_famille;
            this.gridView1.Name = "gridView1";
            // 
            // FAMILLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 622);
            this.Controls.Add(this.panel_famille);
            this.Controls.Add(this.panel_sousfamille);
            this.MaximizeBox = false;
            this.Name = "FAMILLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAMILLE";
            this.Load += new System.EventHandler(this.FAMILLE_Load);
            this.panel_sousfamille.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sousfamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel_famille.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_famille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_sousfamille;
        private System.Windows.Forms.Panel panel_famille;
        private DevExpress.XtraGrid.GridControl grid_sousfamille;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grid_famille;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_valider;
        private DevExpress.XtraEditors.SimpleButton btn_nouveau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codefamille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Designation;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btn_savesousf;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dessousfami;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sousfamille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_fammille;
    }
}