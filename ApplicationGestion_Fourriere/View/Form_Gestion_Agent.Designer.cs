namespace View
{
    partial class Form_Gestion_Agent
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Gestion_Agent = new System.Windows.Forms.DataGridView();
            this.T_CIN_Agent_Rech = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.T_ComboBox_Nom_Fourriere = new System.Windows.Forms.ComboBox();
            this.T_Num_Tel_Agent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Email_Agent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Prenom_Agent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Nom_Agent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Supprimer_Agent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Modifier_Agent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Ajouter_Agent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.T_Mdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.T_Login_Agent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.L_erreur_Fourriere = new System.Windows.Forms.Label();
            this.L_User_Connecter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_Nom_User = new System.Windows.Forms.Label();
            this.L_Prenom_User = new System.Windows.Forms.Label();
            this.L_Email_User = new System.Windows.Forms.Label();
            this.btn_Gestion_Fourriere = new System.Windows.Forms.Button();
            this.btn_Gestion_Agent = new System.Windows.Forms.Button();
            this.btn_Aff_Montant = new System.Windows.Forms.Button();
            this.btn_Mon_Compte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_icon_clear = new System.Windows.Forms.PictureBox();
            this.btn_icon_supp = new System.Windows.Forms.PictureBox();
            this.btn_icon_recherche = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btn_icon_home = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gestion_Agent)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_supp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_recherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btn_icon_supp);
            this.panel4.Controls.Add(this.btn_icon_recherche);
            this.panel4.Controls.Add(this.dataGridView_Gestion_Agent);
            this.panel4.Controls.Add(this.T_CIN_Agent_Rech);
            this.panel4.Location = new System.Drawing.Point(222, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(654, 160);
            this.panel4.TabIndex = 54;
            // 
            // dataGridView_Gestion_Agent
            // 
            this.dataGridView_Gestion_Agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gestion_Agent.Location = new System.Drawing.Point(8, 45);
            this.dataGridView_Gestion_Agent.Name = "dataGridView_Gestion_Agent";
            this.dataGridView_Gestion_Agent.Size = new System.Drawing.Size(639, 110);
            this.dataGridView_Gestion_Agent.TabIndex = 0;
            this.dataGridView_Gestion_Agent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Gestion_Agent_CellContentClick);
            this.dataGridView_Gestion_Agent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Gestion_Agent_CellContentClick);
            // 
            // T_CIN_Agent_Rech
            // 
            this.T_CIN_Agent_Rech.Depth = 0;
            this.T_CIN_Agent_Rech.Hint = "CIN";
            this.T_CIN_Agent_Rech.Location = new System.Drawing.Point(102, 16);
            this.T_CIN_Agent_Rech.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_CIN_Agent_Rech.Name = "T_CIN_Agent_Rech";
            this.T_CIN_Agent_Rech.PasswordChar = '\0';
            this.T_CIN_Agent_Rech.SelectedText = "";
            this.T_CIN_Agent_Rech.SelectionLength = 0;
            this.T_CIN_Agent_Rech.SelectionStart = 0;
            this.T_CIN_Agent_Rech.Size = new System.Drawing.Size(321, 23);
            this.T_CIN_Agent_Rech.TabIndex = 38;
            this.T_CIN_Agent_Rech.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(303, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 6);
            this.label7.TabIndex = 50;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.T_ComboBox_Nom_Fourriere);
            this.panel3.Controls.Add(this.T_Num_Tel_Agent);
            this.panel3.Controls.Add(this.T_Email_Agent);
            this.panel3.Controls.Add(this.T_Prenom_Agent);
            this.panel3.Controls.Add(this.T_Nom_Agent);
            this.panel3.Controls.Add(this.btn_Supprimer_Agent);
            this.panel3.Controls.Add(this.btn_Modifier_Agent);
            this.panel3.Controls.Add(this.btn_Ajouter_Agent);
            this.panel3.Controls.Add(this.T_Mdp);
            this.panel3.Controls.Add(this.T_Login_Agent);
            this.panel3.Location = new System.Drawing.Point(222, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 219);
            this.panel3.TabIndex = 53;
            // 
            // T_ComboBox_Nom_Fourriere
            // 
            this.T_ComboBox_Nom_Fourriere.FormattingEnabled = true;
            this.T_ComboBox_Nom_Fourriere.Location = new System.Drawing.Point(102, 186);
            this.T_ComboBox_Nom_Fourriere.Name = "T_ComboBox_Nom_Fourriere";
            this.T_ComboBox_Nom_Fourriere.Size = new System.Drawing.Size(321, 21);
            this.T_ComboBox_Nom_Fourriere.TabIndex = 37;
            // 
            // T_Num_Tel_Agent
            // 
            this.T_Num_Tel_Agent.Depth = 0;
            this.T_Num_Tel_Agent.Hint = "Num Tel";
            this.T_Num_Tel_Agent.Location = new System.Drawing.Point(102, 156);
            this.T_Num_Tel_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Num_Tel_Agent.Name = "T_Num_Tel_Agent";
            this.T_Num_Tel_Agent.PasswordChar = '\0';
            this.T_Num_Tel_Agent.SelectedText = "";
            this.T_Num_Tel_Agent.SelectionLength = 0;
            this.T_Num_Tel_Agent.SelectionStart = 0;
            this.T_Num_Tel_Agent.Size = new System.Drawing.Size(321, 23);
            this.T_Num_Tel_Agent.TabIndex = 36;
            this.T_Num_Tel_Agent.UseSystemPasswordChar = false;
            // 
            // T_Email_Agent
            // 
            this.T_Email_Agent.Depth = 0;
            this.T_Email_Agent.Hint = "Email";
            this.T_Email_Agent.Location = new System.Drawing.Point(102, 127);
            this.T_Email_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Email_Agent.Name = "T_Email_Agent";
            this.T_Email_Agent.PasswordChar = '\0';
            this.T_Email_Agent.SelectedText = "";
            this.T_Email_Agent.SelectionLength = 0;
            this.T_Email_Agent.SelectionStart = 0;
            this.T_Email_Agent.Size = new System.Drawing.Size(321, 23);
            this.T_Email_Agent.TabIndex = 35;
            this.T_Email_Agent.UseSystemPasswordChar = false;
            // 
            // T_Prenom_Agent
            // 
            this.T_Prenom_Agent.Depth = 0;
            this.T_Prenom_Agent.Hint = "Prenom";
            this.T_Prenom_Agent.Location = new System.Drawing.Point(102, 98);
            this.T_Prenom_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Prenom_Agent.Name = "T_Prenom_Agent";
            this.T_Prenom_Agent.PasswordChar = '\0';
            this.T_Prenom_Agent.SelectedText = "";
            this.T_Prenom_Agent.SelectionLength = 0;
            this.T_Prenom_Agent.SelectionStart = 0;
            this.T_Prenom_Agent.Size = new System.Drawing.Size(321, 23);
            this.T_Prenom_Agent.TabIndex = 34;
            this.T_Prenom_Agent.UseSystemPasswordChar = false;
            // 
            // T_Nom_Agent
            // 
            this.T_Nom_Agent.Depth = 0;
            this.T_Nom_Agent.Hint = "Nom";
            this.T_Nom_Agent.Location = new System.Drawing.Point(102, 69);
            this.T_Nom_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Nom_Agent.Name = "T_Nom_Agent";
            this.T_Nom_Agent.PasswordChar = '\0';
            this.T_Nom_Agent.SelectedText = "";
            this.T_Nom_Agent.SelectionLength = 0;
            this.T_Nom_Agent.SelectionStart = 0;
            this.T_Nom_Agent.Size = new System.Drawing.Size(321, 23);
            this.T_Nom_Agent.TabIndex = 33;
            this.T_Nom_Agent.UseSystemPasswordChar = false;
            // 
            // btn_Supprimer_Agent
            // 
            this.btn_Supprimer_Agent.Depth = 0;
            this.btn_Supprimer_Agent.Location = new System.Drawing.Point(517, 88);
            this.btn_Supprimer_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer_Agent.Name = "btn_Supprimer_Agent";
            this.btn_Supprimer_Agent.Primary = true;
            this.btn_Supprimer_Agent.Size = new System.Drawing.Size(88, 23);
            this.btn_Supprimer_Agent.TabIndex = 31;
            this.btn_Supprimer_Agent.Text = "Supprimer";
            this.btn_Supprimer_Agent.UseVisualStyleBackColor = true;
            this.btn_Supprimer_Agent.Click += new System.EventHandler(this.btn_Supprimer_Agent_Click);
            // 
            // btn_Modifier_Agent
            // 
            this.btn_Modifier_Agent.Depth = 0;
            this.btn_Modifier_Agent.Location = new System.Drawing.Point(517, 56);
            this.btn_Modifier_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier_Agent.Name = "btn_Modifier_Agent";
            this.btn_Modifier_Agent.Primary = true;
            this.btn_Modifier_Agent.Size = new System.Drawing.Size(88, 23);
            this.btn_Modifier_Agent.TabIndex = 30;
            this.btn_Modifier_Agent.Text = "Modifier";
            this.btn_Modifier_Agent.UseVisualStyleBackColor = true;
            this.btn_Modifier_Agent.Click += new System.EventHandler(this.btn_Modifier_Agent_Click);
            // 
            // btn_Ajouter_Agent
            // 
            this.btn_Ajouter_Agent.Depth = 0;
            this.btn_Ajouter_Agent.Location = new System.Drawing.Point(517, 22);
            this.btn_Ajouter_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter_Agent.Name = "btn_Ajouter_Agent";
            this.btn_Ajouter_Agent.Primary = true;
            this.btn_Ajouter_Agent.Size = new System.Drawing.Size(88, 23);
            this.btn_Ajouter_Agent.TabIndex = 29;
            this.btn_Ajouter_Agent.Text = "Ajouter";
            this.btn_Ajouter_Agent.UseVisualStyleBackColor = true;
            this.btn_Ajouter_Agent.Click += new System.EventHandler(this.btn_Ajouter_Agent_Click);
            // 
            // T_Mdp
            // 
            this.T_Mdp.Depth = 0;
            this.T_Mdp.Hint = "Mot de passe";
            this.T_Mdp.Location = new System.Drawing.Point(102, 40);
            this.T_Mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Mdp.Name = "T_Mdp";
            this.T_Mdp.PasswordChar = '*';
            this.T_Mdp.SelectedText = "";
            this.T_Mdp.SelectionLength = 0;
            this.T_Mdp.SelectionStart = 0;
            this.T_Mdp.Size = new System.Drawing.Size(321, 23);
            this.T_Mdp.TabIndex = 28;
            this.T_Mdp.UseSystemPasswordChar = false;
            // 
            // T_Login_Agent
            // 
            this.T_Login_Agent.Depth = 0;
            this.T_Login_Agent.Hint = "Login";
            this.T_Login_Agent.Location = new System.Drawing.Point(102, 11);
            this.T_Login_Agent.MouseState = MaterialSkin.MouseState.HOVER;
            this.T_Login_Agent.Name = "T_Login_Agent";
            this.T_Login_Agent.PasswordChar = '\0';
            this.T_Login_Agent.SelectedText = "";
            this.T_Login_Agent.SelectionLength = 0;
            this.T_Login_Agent.SelectionStart = 0;
            this.T_Login_Agent.Size = new System.Drawing.Size(321, 23);
            this.T_Login_Agent.TabIndex = 27;
            this.T_Login_Agent.UseSystemPasswordChar = false;
            // 
            // L_erreur_Fourriere
            // 
            this.L_erreur_Fourriere.AutoSize = true;
            this.L_erreur_Fourriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_erreur_Fourriere.ForeColor = System.Drawing.Color.Red;
            this.L_erreur_Fourriere.Location = new System.Drawing.Point(314, 297);
            this.L_erreur_Fourriere.Name = "L_erreur_Fourriere";
            this.L_erreur_Fourriere.Size = new System.Drawing.Size(0, 20);
            this.L_erreur_Fourriere.TabIndex = 47;
            // 
            // L_User_Connecter
            // 
            this.L_User_Connecter.AutoSize = true;
            this.L_User_Connecter.ForeColor = System.Drawing.SystemColors.Control;
            this.L_User_Connecter.Location = new System.Drawing.Point(219, 50);
            this.L_User_Connecter.Name = "L_User_Connecter";
            this.L_User_Connecter.Size = new System.Drawing.Size(0, 13);
            this.L_User_Connecter.TabIndex = 48;
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
            // btn_Gestion_Fourriere
            // 
            this.btn_Gestion_Fourriere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Gestion_Fourriere.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Fourriere.Location = new System.Drawing.Point(46, 245);
            this.btn_Gestion_Fourriere.Name = "btn_Gestion_Fourriere";
            this.btn_Gestion_Fourriere.Size = new System.Drawing.Size(147, 35);
            this.btn_Gestion_Fourriere.TabIndex = 33;
            this.btn_Gestion_Fourriere.Text = "Gestion Fourriere";
            this.btn_Gestion_Fourriere.UseVisualStyleBackColor = false;
            this.btn_Gestion_Fourriere.Click += new System.EventHandler(this.btn_Gestion_Fourriere_Click);
            // 
            // btn_Gestion_Agent
            // 
            this.btn_Gestion_Agent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Gestion_Agent.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Agent.Location = new System.Drawing.Point(46, 286);
            this.btn_Gestion_Agent.Name = "btn_Gestion_Agent";
            this.btn_Gestion_Agent.Size = new System.Drawing.Size(147, 35);
            this.btn_Gestion_Agent.TabIndex = 34;
            this.btn_Gestion_Agent.Text = "Gestion Agent";
            this.btn_Gestion_Agent.UseVisualStyleBackColor = false;
            this.btn_Gestion_Agent.Click += new System.EventHandler(this.btn_Gestion_Agent_Click);
            // 
            // btn_Aff_Montant
            // 
            this.btn_Aff_Montant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Aff_Montant.ForeColor = System.Drawing.Color.White;
            this.btn_Aff_Montant.Location = new System.Drawing.Point(46, 331);
            this.btn_Aff_Montant.Name = "btn_Aff_Montant";
            this.btn_Aff_Montant.Size = new System.Drawing.Size(147, 35);
            this.btn_Aff_Montant.TabIndex = 35;
            this.btn_Aff_Montant.Text = "Afficher Montant";
            this.btn_Aff_Montant.UseVisualStyleBackColor = false;
            this.btn_Aff_Montant.Click += new System.EventHandler(this.btn_Montant_Click);
            // 
            // btn_Mon_Compte
            // 
            this.btn_Mon_Compte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Mon_Compte.ForeColor = System.Drawing.Color.White;
            this.btn_Mon_Compte.Location = new System.Drawing.Point(46, 371);
            this.btn_Mon_Compte.Name = "btn_Mon_Compte";
            this.btn_Mon_Compte.Size = new System.Drawing.Size(147, 35);
            this.btn_Mon_Compte.TabIndex = 36;
            this.btn_Mon_Compte.Text = "Mon compte";
            this.btn_Mon_Compte.UseVisualStyleBackColor = false;
            this.btn_Mon_Compte.Click += new System.EventHandler(this.btn_Mon_Compte_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Mon_Compte);
            this.panel1.Controls.Add(this.btn_Aff_Montant);
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
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(244, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gestion Agent";
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
            this.panel2.TabIndex = 52;
            // 
            // btn_icon_clear
            // 
            this.btn_icon_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_icon_clear.BackgroundImage = global::View.Properties.Resources.broom_clear_512;
            this.btn_icon_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_clear.Location = new System.Drawing.Point(678, 44);
            this.btn_icon_clear.Name = "btn_icon_clear";
            this.btn_icon_clear.Size = new System.Drawing.Size(28, 25);
            this.btn_icon_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon_clear.TabIndex = 55;
            this.btn_icon_clear.TabStop = false;
            this.btn_icon_clear.Click += new System.EventHandler(this.btn_icon_clear_Click);
            // 
            // btn_icon_supp
            // 
            this.btn_icon_supp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_icon_supp.BackgroundImage = global::View.Properties.Resources.supprimer;
            this.btn_icon_supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_supp.Location = new System.Drawing.Point(496, 14);
            this.btn_icon_supp.Name = "btn_icon_supp";
            this.btn_icon_supp.Size = new System.Drawing.Size(31, 25);
            this.btn_icon_supp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon_supp.TabIndex = 39;
            this.btn_icon_supp.TabStop = false;
            this.btn_icon_supp.Click += new System.EventHandler(this.btn_icon_supp_Click);
            // 
            // btn_icon_recherche
            // 
            this.btn_icon_recherche.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_icon_recherche.BackgroundImage = global::View.Properties.Resources.recherche;
            this.btn_icon_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_recherche.Location = new System.Drawing.Point(451, 14);
            this.btn_icon_recherche.Name = "btn_icon_recherche";
            this.btn_icon_recherche.Size = new System.Drawing.Size(39, 25);
            this.btn_icon_recherche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon_recherche.TabIndex = 29;
            this.btn_icon_recherche.TabStop = false;
            this.btn_icon_recherche.Click += new System.EventHandler(this.btn_icon_recherche_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.BackgroundImage = global::View.Properties.Resources.ajout;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(248, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox12.BackgroundImage = global::View.Properties.Resources.supprimer;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Location = new System.Drawing.Point(487, 88);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 23);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 40;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox11.BackgroundImage = global::View.Properties.Resources.recherche;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(487, 56);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 23);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 40;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox10.BackgroundImage = global::View.Properties.Resources.ajout;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(487, 22);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 45;
            this.pictureBox10.TabStop = false;
            // 
            // btn_icon_home
            // 
            this.btn_icon_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_icon_home.BackgroundImage = global::View.Properties.Resources.home;
            this.btn_icon_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_icon_home.Location = new System.Drawing.Point(605, 3);
            this.btn_icon_home.Name = "btn_icon_home";
            this.btn_icon_home.Size = new System.Drawing.Size(46, 34);
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
            this.pictureBox5.Location = new System.Drawing.Point(12, 374);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox4.BackgroundImage = global::View.Properties.Resources.unnamed;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(12, 335);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.BackgroundImage = global::View.Properties.Resources.settings;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.settings;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
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
            // Form_Gestion_Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.btn_icon_clear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.L_erreur_Fourriere);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.L_User_Connecter);
            this.Name = "Form_Gestion_Agent";
            this.Text = "Form_Gestion_Agent";
            this.Load += new System.EventHandler(this.Form_Gestion_Agent_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gestion_Agent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_supp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon_recherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btn_icon_supp;
        private System.Windows.Forms.PictureBox btn_icon_recherche;
        private System.Windows.Forms.DataGridView dataGridView_Gestion_Agent;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_CIN_Agent_Rech;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ComboBox T_ComboBox_Nom_Fourriere;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Num_Tel_Agent;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Email_Agent;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Prenom_Agent;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Nom_Agent;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Supprimer_Agent;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Modifier_Agent;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Ajouter_Agent;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Mdp;
        private MaterialSkin.Controls.MaterialSingleLineTextField T_Login_Agent;
        private System.Windows.Forms.Label L_erreur_Fourriere;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Gestion_Fourriere;
        private System.Windows.Forms.Button btn_Gestion_Agent;
        private System.Windows.Forms.Button btn_Aff_Montant;
        private System.Windows.Forms.Button btn_Mon_Compte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btn_icon_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}