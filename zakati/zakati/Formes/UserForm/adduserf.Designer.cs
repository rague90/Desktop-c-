
namespace zakati.Formes.UserForm
{
    partial class adduserf
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
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduserf));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.zakateDataSet = new zakati.zakateDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new zakati.zakateDataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new zakati.zakateDataSetTableAdapters.TableAdapterManager();
            this.ADD_bx = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Close_bx = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            nomLabel1 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zakateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(36, 29);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(30, 13);
            nomLabel1.TabIndex = 10;
            nomLabel1.Text = "nom:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(36, 62);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(36, 93);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 12;
            dateLabel.Text = "Date:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(36, 124);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "phone:";
            // 
            // zakateDataSet
            // 
            this.zakateDataSet.DataSetName = "zakateDataSet";
            this.zakateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.zakateDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.istifadaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = zakati.zakateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // ADD_bx
            // 
            this.ADD_bx.AllowToggling = false;
            this.ADD_bx.AnimationSpeed = 200;
            this.ADD_bx.AutoGenerateColors = false;
            this.ADD_bx.BackColor = System.Drawing.Color.Transparent;
            this.ADD_bx.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ADD_bx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADD_bx.BackgroundImage")));
            this.ADD_bx.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ADD_bx.ButtonText = "Ajouter";
            this.ADD_bx.ButtonTextMarginLeft = 0;
            this.ADD_bx.ColorContrastOnClick = 45;
            this.ADD_bx.ColorContrastOnHover = 45;
            this.ADD_bx.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ADD_bx.CustomizableEdges = borderEdges1;
            this.ADD_bx.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ADD_bx.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ADD_bx.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ADD_bx.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ADD_bx.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ADD_bx.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_bx.ForeColor = System.Drawing.Color.White;
            this.ADD_bx.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_bx.IconMarginLeft = 11;
            this.ADD_bx.IconPadding = 10;
            this.ADD_bx.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_bx.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ADD_bx.IdleBorderRadius = 3;
            this.ADD_bx.IdleBorderThickness = 1;
            this.ADD_bx.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ADD_bx.IdleIconLeftImage = null;
            this.ADD_bx.IdleIconRightImage = null;
            this.ADD_bx.IndicateFocus = false;
            this.ADD_bx.Location = new System.Drawing.Point(96, 141);
            this.ADD_bx.Name = "ADD_bx";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ADD_bx.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.ADD_bx.OnPressedState = stateProperties2;
            this.ADD_bx.Size = new System.Drawing.Size(146, 45);
            this.ADD_bx.TabIndex = 9;
            this.ADD_bx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ADD_bx.TextMarginLeft = 0;
            this.ADD_bx.UseDefaultRadiusAndThickness = true;
            this.ADD_bx.Click += new System.EventHandler(this.ADD_bx_Click);
            // 
            // Close_bx
            // 
            this.Close_bx.AllowToggling = false;
            this.Close_bx.AnimationSpeed = 200;
            this.Close_bx.AutoGenerateColors = false;
            this.Close_bx.BackColor = System.Drawing.Color.Transparent;
            this.Close_bx.BackColor1 = System.Drawing.Color.Red;
            this.Close_bx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_bx.BackgroundImage")));
            this.Close_bx.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Close_bx.ButtonText = "Sorté";
            this.Close_bx.ButtonTextMarginLeft = 0;
            this.Close_bx.ColorContrastOnClick = 45;
            this.Close_bx.ColorContrastOnHover = 45;
            this.Close_bx.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Close_bx.CustomizableEdges = borderEdges2;
            this.Close_bx.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Close_bx.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Close_bx.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Close_bx.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Close_bx.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Close_bx.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.Close_bx.ForeColor = System.Drawing.Color.White;
            this.Close_bx.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Close_bx.IconMarginLeft = 11;
            this.Close_bx.IconPadding = 10;
            this.Close_bx.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Close_bx.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Close_bx.IdleBorderRadius = 3;
            this.Close_bx.IdleBorderThickness = 1;
            this.Close_bx.IdleFillColor = System.Drawing.Color.Red;
            this.Close_bx.IdleIconLeftImage = null;
            this.Close_bx.IdleIconRightImage = null;
            this.Close_bx.IndicateFocus = false;
            this.Close_bx.Location = new System.Drawing.Point(267, 141);
            this.Close_bx.Name = "Close_bx";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.Close_bx.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Close_bx.OnPressedState = stateProperties4;
            this.Close_bx.Size = new System.Drawing.Size(151, 45);
            this.Close_bx.TabIndex = 10;
            this.Close_bx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close_bx.TextMarginLeft = 0;
            this.Close_bx.UseDefaultRadiusAndThickness = true;
            this.Close_bx.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(96, 22);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(322, 20);
            this.nomTextBox.TabIndex = 11;
            this.nomTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(96, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(322, 20);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utilisateurBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(96, 87);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(322, 20);
            this.dateDateTimePicker.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(96, 117);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(322, 20);
            this.phoneTextBox.TabIndex = 14;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // adduserf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 205);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(nomLabel1);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.Close_bx);
            this.Controls.Add(this.ADD_bx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adduserf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajoute un Utilisateur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adduserf_FormClosing);
            this.Load += new System.EventHandler(this.adduserf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zakateDataSet zakateDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private zakateDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private zakateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ADD_bx;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Close_bx;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}