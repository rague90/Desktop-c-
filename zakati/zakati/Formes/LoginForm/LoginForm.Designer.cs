
namespace zakati.Formes.LoginForm
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.Login_bx = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.username_box.ForeColor = System.Drawing.Color.Black;
            this.username_box.Location = new System.Drawing.Point(70, 109);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(216, 20);
            this.username_box.TabIndex = 0;
            this.username_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.username_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_box_KeyDown);
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.password_box.ForeColor = System.Drawing.Color.Black;
            this.password_box.Location = new System.Drawing.Point(70, 145);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(216, 20);
            this.password_box.TabIndex = 1;
            this.password_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.password_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_box_KeyDown);
            // 
            // Login_bx
            // 
            this.Login_bx.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login_bx.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_bx.ForeColor = System.Drawing.Color.White;
            this.Login_bx.Location = new System.Drawing.Point(70, 185);
            this.Login_bx.Name = "Login_bx";
            this.Login_bx.Size = new System.Drawing.Size(216, 57);
            this.Login_bx.TabIndex = 2;
            this.Login_bx.Text = "Se connecter";
            this.Login_bx.UseVisualStyleBackColor = false;
            this.Login_bx.Click += new System.EventHandler(this.Login_bx_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.close.SetToolTip(this.pictureBox1, "close application");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close
            // 
            this.close.IsBalloon = true;
            this.close.Popup += new System.Windows.Forms.PopupEventHandler(this.close_Popup);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_bx);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button Login_bx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip close;
    }
}