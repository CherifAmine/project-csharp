namespace View
{
    partial class Form_Gestion_Fourriere
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
            this.L_erreur_Fourriere = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Gestion_Fourriere = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Supprimer_Fourriere = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier_Fourriere = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter_Fourriere = new MaterialSkin.Controls.MaterialRaisedButton();
            this.T_Nom_Fourriere = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Id_Fourriere = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.L_User_Connecter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_Nom_User = new System.Windows.Forms.Label();
            this.L_Prenom_User = new System.Windows.Forms.Label();
            this.L_Email_User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Mon_Compte = new System.Windows.Forms.Button();
            this.btn_Montant = new System.Windows.Forms.Button();
            this.btn_Gestion_Agent = new System.Windows.Forms.Button();
            this.btn_Gestion_Fourriere = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_icon_clear = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_icon_home = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gestion_Fourriere)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // L_erreur_Fourriere
            // 
            this.L_erreur_Fourriere.AutoSize = true;
            this.L_erreur_Fourriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_erreur_Fourriere.ForeColor = System.Drawing.Color.Red;
            this.L_erreur_Fourriere.Location = new System.Drawing.Point(320, 236);
            this.L_erreur_Fourriere.Name = "L_erreur_Fourriere";
            this.L_erreur_Fourriere.Size = new System.Drawing.Size(0, 20);
            this.L_erreur_Fourriere.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView_Gestion_Fourriere);
            this.panel4.Location = new System.Drawing.Point(240, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 212);
            this.panel4.TabIndex = 46;
            // 
            // dataGridView_Gestion_Fourriere
            // 
            this.dataGridView_Gestion_Fourriere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gestion_Fourriere.Location = new System.Drawing.Point(13, 13);
            this.dataGridView_Gestion_Fourriere.Name = "dataGridView_Gestion_Fourriere";
            this.dataGridView_Gestion_Fourriere.Size = new System.Drawing.Size(594, 188);
            this.dataGridView_Gestion_Fourriere.TabIndex = 0;
            this.dataGridView_Gestion_Fourriere.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Gestion_Fourriere_CellContentClick);
            this.dataGridView_Gestion_Fourriere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Gestion_Fourriere_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(306, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 6);
            this.label7.TabIndex = 42;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_Supprimer_Fourriere);
            this.panel3.Controls.Add(this.btn_Modifier_Fourriere);
            this.panel3.Controls.Add(this.btn_Ajouter_Fourriere);
            this.panel3.Controls.Add(this.T_Nom_Fourriere);
            this.panel3.Controls.Add(this.T_Id_Fourriere);
            this.panel3.Location = new System.Drawing.Point(237, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 140);
            this.panel3.TabIndex = 45;
            // 
            // btn_Supprimer_Fourriere
            // 
            this.btn_Supprimer_Fourriere.Depth = 0;
            this.btn_Supprimer_Fourriere.Location = new System.Drawing.Point(517, 88);
            this.btn_Supprimer_Fourriere.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer_Fourriere.Name = "btn_Supprimer_Fourriere";
            this.btn_Supprimer_Fourriere.Primary = true;
            this.btn_Supprimer_Fourriere.Size = new System.Drawing.Size(88, 23);
            this.btn_Supprimer_Fourriere.TabIndex = 31;
            this.btn_Supprimer_Fourriere.Text = "Supprimer";
            this.btn_Supprimer_Fourriere.UseVisualStyleBackColor = true;
            this.btn_Supprimer_Fourriere.Click += new System.EventHandler(this.btn_Supprimer_Fourriere_Click);
            // 
            // btn_Modifier_Fourriere
            // 
            this.btn_Modifier_Fourriere.Depth = 0;
            this.btn_Modifier_Fourriere.Location = new System.Drawing.Point(517, 56);
            this.btn_Modifier_Fourriere.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier_Fourriere.Name = "btn_Modifier_Fourriere";
            this.btn_Modifier_Fourriere.Primary = true;
            this.btn_Modifier_Fourriere.Size = new System.Drawing.Size(88, 23);
            this.btn_Modifier_Fourriere.TabIndex = 30;
            this.btn_Modifier_Fourriere.Text = "Modifier";
            this.btn_Modifier_Fourriere.UseVisualStyleBackColor = true;
            this.btn_Modifier_Fourriere.Click += new System.EventHandler(this.btn_Modifier_Fourriere_Click);
            // 
            // btn_Ajouter_Fourriere
            // 
            this.btn_Ajouter_Fourriere.Depth = 0;
            this.btn_Ajouter_Fourriere.Location = new System.Drawing.Point(517, 22);
            this.btn_Ajouter_Fourriere.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter_Fourriere.Name = "btn_Ajouter_Fourriere";
            this.btn_Ajouter_Fourriere.Primary = true;
            this.btn_Ajouter_Fourriere.Size = new System.Drawing.Size(88, 23);
            this.btn_Ajouter_Fourriere.TabIndex = 29;
            this.btn_Ajouter_Fourriere.Text = "Ajouter";
            this.btn_Ajouter_Fourriere.UseVisualStyleBackColor = true;
            this.btn_Ajouter_Fourriere.Click += new System.EventHandler(this.btn_Ajouter_Fourriere_Click);
            // 
            // T_Nom_Fourriere
            // 
            this.T_Nom_Fourriere.Depth = 0;
            this.T_Nom_Fourriere.Hint = "Nom Fourriere";
            this.T_Nom_Fourriere.Location = new System.Drawing.Point(102, 77);
            this.T_Nom_Fourriere.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Nom_Fourriere.Name = "T_Nom_Fourriere";
            this.T_Nom_Fourriere.PasswordChar = '\0';
            this.T_Nom_Fourriere.SelectedText = "";
            this.T_Nom_Fourriere.SelectionLength = 0;
            this.T_Nom_Fourriere.SelectionStart = 0;
            this.T_Nom_Fourriere.Size = new System.Drawing.Size(321, 23);
            this.T_Nom_Fourriere.TabIndex = 28;
            this.T_Nom_Fourriere.UseSystemPasswordChar = false;
            // 
            // T_Id_Fourriere
            // 
            this.T_Id_Fourriere.Depth = 0;
            this.T_Id_Fourriere.Hint = "id Fourriere";
            this.T_Id_Fourriere.Location = new System.Drawing.Point(102, 45);
            this.T_Id_Fourriere.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Id_Fourriere.Name = "T_Id_Fourriere";
            this.T_Id_Fourriere.PasswordChar = '\0';
            this.T_Id_Fourriere.SelectedText = "";
            this.T_Id_Fourriere.SelectionLength = 0;
            this.T_Id_Fourriere.SelectionStart = 0;
            this.T_Id_Fourriere.Size = new System.Drawing.Size(321, 23);
            this.T_Id_Fourriere.TabIndex = 27;
            this.T_Id_Fourriere.UseSystemPasswordChar = false;
            // 
            // L_User_Connecter
            // 
            this.L_User_Connecter.AutoSize = true;
            this.L_User_Connecter.ForeColor = System.Drawing.SystemColors.Control;
            this.L_User_Connecter.Location = new System.Drawing.Point(219, 61);
            this.L_User_Connecter.Name = "L_User_Connecter";
            this.L_User_Connecter.Size = new System.Drawing.Size(0, 13);
            this.L_User_Connecter.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "---------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(106, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Administrateur";
            // 
            // L_Nom_User
            // 
            this.L_Nom_User.AutoSize = true;
            this.L_Nom_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nom_User.ForeColor = System.Drawing.Color.White;
            this.L_Nom_User.Location = new System.Drawing.Point(71, 142);
            this.L_Nom_User.Name = "L_Nom_User";
            this.L_Nom_User.Size = new System.Drawing.Size(0, 13);
            this.L_Nom_User.TabIndex = 26;
            // 
            // L_Prenom_User
            // 
            this.L_Prenom_User.AutoSize = true;
            this.L_Prenom_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Prenom_User.ForeColor = System.Drawing.Color.White;
            this.L_Prenom_User.Location = new System.Drawing.Point(71, 163);
            this.L_Prenom_User.Name = "L_Prenom_User";
            this.L_Prenom_User.Size = new System.Drawing.Size(0, 13);
            this.L_Prenom_User.TabIndex = 27;
            // 
            // L_Email_User
            // 
            this.L_Email_User.AutoSize = true;
            this.L_Email_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Email_User.ForeColor = System.Drawing.Color.White;
            this.L_Email_User.Location = new System.Drawing.Point(71, 184);
            this.L_Email_User.Name = "L_Email_User";
            this.L_Email_User.Size = new System.Drawing.Size(0, 13);
            this.L_Email_User.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Mon_Compte);
            this.panel1.Controls.Add(this.btn_Montant);
            this.panel1.Controls.Add(this.btn_Gestion_Agent);
            this.panel1.Controls.Add(this.btn_Gestion_Fourriere);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.L_Email_User);
            this.panel1.Controls.Add(this.L_Prenom_User);
            this.panel1.Controls.Add(this.L_Nom_User);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 488);
            this.panel1.TabIndex = 43;
            // 
            // btn_Mon_Compte
            // 
            this.btn_Mon_Compte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Mon_Compte.ForeColor = System.Drawing.Color.White;
            this.btn_Mon_Compte.Location = new System.Drawing.Point(46, 365);
            this.btn_Mon_Compte.Name = "btn_Mon_Compte";
            this.btn_Mon_Compte.Size = new System.Drawing.Size(147, 35);
            this.btn_Mon_Compte.TabIndex = 44;
            this.btn_Mon_Compte.Text = "Mon compte";
            this.btn_Mon_Compte.UseVisualStyleBackColor = false;
            this.btn_Mon_Compte.Click += new System.EventHandler(this.btn_Mon_Compte_Click);
            // 
            // btn_Montant
            // 
            this.btn_Montant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Montant.ForeColor = System.Drawing.Color.White;
            this.btn_Montant.Location = new System.Drawing.Point(46, 325);
            this.btn_Montant.Name = "btn_Montant";
            this.btn_Montant.Size = new System.Drawing.Size(147, 35);
            this.btn_Montant.TabIndex = 43;
            this.btn_Montant.Text = "Afficher Montant";
            this.btn_Montant.UseVisualStyleBackColor = false;
            this.btn_Montant.Click += new System.EventHandler(this.btn_Montant_Click);
            // 
            // btn_Gestion_Agent
            // 
            this.btn_Gestion_Agent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Gestion_Agent.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Agent.Location = new System.Drawing.Point(46, 280);
            this.btn_Gestion_Agent.Name = "btn_Gestion_Agent";
            this.btn_Gestion_Agent.Size = new System.Drawing.Size(147, 35);
            this.btn_Gestion_Agent.TabIndex = 42;
            this.btn_Gestion_Agent.Text = "Gestion Agent";
            this.btn_Gestion_Agent.UseVisualStyleBackColor = false;
            this.btn_Gestion_Agent.Click += new System.EventHandler(this.btn_Gestion_Agent_Click);
            // 
            // btn_Gestion_Fourriere
            // 
            this.btn_Gestion_Fourriere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Gestion_Fourriere.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Fourriere.Location = new System.Drawing.Point(46, 239);
            this.btn_Gestion_Fourriere.Name = "btn_Gestion_Fourriere";
            this.btn_Gestion_Fourriere.Size = new System.Drawing.Size(147, 35);
            this.btn_Gestion_Fourriere.TabIndex = 41;
            this.btn_Gestion_Fourriere.Text = "Gestion Fourriere";
            this.btn_Gestion_Fourriere.UseVisualStyleBackColor = false;
            this.btn_Gestion_Fourriere.Click += new System.EventHandler(this.btn_Gestion_Fourriere_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(244, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gestion Fourriere";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.btn_icon_home);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 41);
            this.panel2.TabIndex = 44;
            // 
            // btn_icon_clear
            // 
            this.btn_icon_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_icon_clear.BackgroundImage = global::View.Properties.Resources.broom_clear_512;
            this.btn_icon_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_clear.Location = new System.Drawing.Point(681, 55);
            this.btn_icon_clear.Name = "btn_icon_clear";
            this.btn_icon_clear.Size = new System.Drawing.Size(28, 25);
            this.btn_icon_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon_clear.TabIndex = 38;
            this.btn_icon_clear.TabStop = false;
            this.btn_icon_clear.Click += new System.EventHandler(this.btn_icon_clear_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox6.BackgroundImage = global::View.Properties.Resources.data_add;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(253, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // btn_icon_home
            // 
            this.btn_icon_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_icon_home.BackgroundImage = global::View.Properties.Resources.home;
            this.btn_icon_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_home.Location = new System.Drawing.Point(612, 3);
            this.btn_icon_home.Name = "btn_icon_home";
            this.btn_icon_home.Size = new System.Drawing.Size(37, 31);
            this.btn_icon_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon_home.TabIndex = 31;
            this.btn_icon_home.TabStop = false;
            this.btn_icon_home.Click += new System.EventHandler(this.btn_icon_home_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox5.BackgroundImage = global::View.Properties.Resources.user;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(12, 368);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox4.BackgroundImage = global::View.Properties.Resources.unnamed;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(12, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.BackgroundImage = global::View.Properties.Resources.settings;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.settings;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImage = global::View.Properties.Resources.icon_compte;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::View.Properties.Resources.shutdown_icon_14_256;
            this.pictureBox7.Location = new System.Drawing.Point(657, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Form_Gestion_Fourriere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.btn_icon_clear);
            this.Controls.Add(this.L_erreur_Fourriere);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.L_User_Connecter);
            this.Name = "Form_Gestion_Fourriere";
            this.Text = "Gestion Fourriere";
            this.Load += new System.EventHandler(this.Form_Gestion_Fourriere_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gestion_Fourriere)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_icon_clear;
        private System.Windows.Forms.Label L_erreur_Fourriere;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Gestion_Fourriere;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Supprimer_Fourriere;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Modifier_Fourriere;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Ajouter_Fourriere;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Nom_Fourriere;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Id_Fourriere;
        private System.Windows.Forms.Label L_User_Connecter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_Nom_User;
        private System.Windows.Forms.Label L_Prenom_User;
        private System.Windows.Forms.Label L_Email_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btn_icon_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Mon_Compte;
        private System.Windows.Forms.Button btn_Montant;
        private System.Windows.Forms.Button btn_Gestion_Agent;
        private System.Windows.Forms.Button btn_Gestion_Fourriere;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}