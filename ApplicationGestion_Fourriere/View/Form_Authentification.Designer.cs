namespace View
{
    partial class Form_Authentification
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.L_Verification = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.T_Mdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BackgroundImage = global::View.Properties.Resources.auth;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(270, 274);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BackgroundImage = global::View.Properties.Resources.auth;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(270, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gestion de Fourriere";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::View.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(104, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // L_Verification
            // 
            this.L_Verification.AutoSize = true;
            this.L_Verification.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L_Verification.ForeColor = System.Drawing.Color.Red;
            this.L_Verification.Location = new System.Drawing.Point(109, 199);
            this.L_Verification.Name = "L_Verification";
            this.L_Verification.Size = new System.Drawing.Size(0, 13);
            this.L_Verification.TabIndex = 26;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(175, 325);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton1.TabIndex = 25;
            this.materialFlatButton1.Text = "Connexion";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // T_Mdp
            // 
            this.T_Mdp.BackColor = System.Drawing.SystemColors.Control;
            this.T_Mdp.Depth = 0;
            this.T_Mdp.Hint = "   Mot de passe";
            this.T_Mdp.Location = new System.Drawing.Point(38, 274);
            this.T_Mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Mdp.Name = "T_Mdp";
            this.T_Mdp.PasswordChar = '*';
            this.T_Mdp.SelectedText = "";
            this.T_Mdp.SelectionLength = 0;
            this.T_Mdp.SelectionStart = 0;
            this.T_Mdp.Size = new System.Drawing.Size(226, 23);
            this.T_Mdp.TabIndex = 24;
            this.T_Mdp.UseSystemPasswordChar = false;
            // 
            // T_Login
            // 
            this.T_Login.BackColor = System.Drawing.SystemColors.Control;
            this.T_Login.Depth = 0;
            this.T_Login.Hint = "   Login";
            this.T_Login.Location = new System.Drawing.Point(38, 236);
            this.T_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Login.Name = "T_Login";
            this.T_Login.PasswordChar = '\0';
            this.T_Login.SelectedText = "";
            this.T_Login.SelectionLength = 0;
            this.T_Login.SelectionStart = 0;
            this.T_Login.Size = new System.Drawing.Size(226, 23);
            this.T_Login.TabIndex = 23;
            this.T_Login.UseSystemPasswordChar = false;
            // 
            // Form_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.L_Verification);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.T_Mdp);
            this.Controls.Add(this.T_Login);
            this.Name = "Form_Authentification";
            this.Text = "Form_Authentification";
            this.Load += new System.EventHandler(this.Form_Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label L_Verification;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Mdp;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Login;
    }
}