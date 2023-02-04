namespace HeroScape_Army_Randomizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_DraftRandom = new System.Windows.Forms.RadioButton();
            this.rb_DraftSynergy = new System.Windows.Forms.RadioButton();
            this.rtb_MainDisplay = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reroll = new System.Windows.Forms.Button();
            this.btn_ChangeName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_AllowSquads = new System.Windows.Forms.CheckBox();
            this.cb_AllowHeros = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_DuplicateCommonFigures = new System.Windows.Forms.RadioButton();
            this.rb_DuplicateAll = new System.Windows.Forms.RadioButton();
            this.rb_NoDuplicates = new System.Windows.Forms.RadioButton();
            this.rb_DuplicateStandard = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_NumPlayers = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nud_Points = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GenerateArmies = new System.Windows.Forms.Button();
            this.btn_AddPlayer = new System.Windows.Forms.Button();
            this.btn_RemovePlayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_PlayerList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_FigureFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NumPlayers)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Points)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(379, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Army Randomizer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.rb_DraftRandom);
            this.groupBox1.Controls.Add(this.rb_DraftSynergy);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drafting Type";
            // 
            // rb_DraftRandom
            // 
            this.rb_DraftRandom.AutoSize = true;
            this.rb_DraftRandom.Checked = true;
            this.rb_DraftRandom.Location = new System.Drawing.Point(7, 46);
            this.rb_DraftRandom.Name = "rb_DraftRandom";
            this.rb_DraftRandom.Size = new System.Drawing.Size(170, 25);
            this.rb_DraftRandom.TabIndex = 1;
            this.rb_DraftRandom.TabStop = true;
            this.rb_DraftRandom.Text = "Completely Random";
            this.rb_DraftRandom.UseVisualStyleBackColor = true;
            // 
            // rb_DraftSynergy
            // 
            this.rb_DraftSynergy.AutoSize = true;
            this.rb_DraftSynergy.Location = new System.Drawing.Point(7, 21);
            this.rb_DraftSynergy.Name = "rb_DraftSynergy";
            this.rb_DraftSynergy.Size = new System.Drawing.Size(165, 25);
            this.rb_DraftSynergy.TabIndex = 0;
            this.rb_DraftSynergy.Text = "Synergy Dependant";
            this.rb_DraftSynergy.UseVisualStyleBackColor = true;
            // 
            // rtb_MainDisplay
            // 
            this.rtb_MainDisplay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_MainDisplay.Location = new System.Drawing.Point(277, 180);
            this.rtb_MainDisplay.Name = "rtb_MainDisplay";
            this.rtb_MainDisplay.ReadOnly = true;
            this.rtb_MainDisplay.Size = new System.Drawing.Size(425, 402);
            this.rtb_MainDisplay.TabIndex = 6;
            this.rtb_MainDisplay.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Options";
            // 
            // btn_Reroll
            // 
            this.btn_Reroll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reroll.Location = new System.Drawing.Point(14, 227);
            this.btn_Reroll.Name = "btn_Reroll";
            this.btn_Reroll.Size = new System.Drawing.Size(113, 43);
            this.btn_Reroll.TabIndex = 8;
            this.btn_Reroll.Text = "Re-Roll Army";
            this.btn_Reroll.UseVisualStyleBackColor = true;
            this.btn_Reroll.Click += new System.EventHandler(this.btn_Reroll_Click);
            // 
            // btn_ChangeName
            // 
            this.btn_ChangeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangeName.Location = new System.Drawing.Point(136, 227);
            this.btn_ChangeName.Name = "btn_ChangeName";
            this.btn_ChangeName.Size = new System.Drawing.Size(113, 43);
            this.btn_ChangeName.TabIndex = 9;
            this.btn_ChangeName.Text = "Change Name";
            this.btn_ChangeName.UseVisualStyleBackColor = true;
            this.btn_ChangeName.Click += new System.EventHandler(this.btn_ChangeName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.cb_AllowSquads);
            this.groupBox2.Controls.Add(this.cb_AllowHeros);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allowed Figure Types";
            // 
            // cb_AllowSquads
            // 
            this.cb_AllowSquads.AutoSize = true;
            this.cb_AllowSquads.Checked = true;
            this.cb_AllowSquads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AllowSquads.Location = new System.Drawing.Point(9, 46);
            this.cb_AllowSquads.Name = "cb_AllowSquads";
            this.cb_AllowSquads.Size = new System.Drawing.Size(80, 25);
            this.cb_AllowSquads.TabIndex = 1;
            this.cb_AllowSquads.Text = "Squads";
            this.cb_AllowSquads.UseVisualStyleBackColor = true;
            // 
            // cb_AllowHeros
            // 
            this.cb_AllowHeros.AutoSize = true;
            this.cb_AllowHeros.Checked = true;
            this.cb_AllowHeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AllowHeros.Location = new System.Drawing.Point(9, 21);
            this.cb_AllowHeros.Name = "cb_AllowHeros";
            this.cb_AllowHeros.Size = new System.Drawing.Size(70, 25);
            this.cb_AllowHeros.TabIndex = 0;
            this.cb_AllowHeros.Text = "Heros";
            this.cb_AllowHeros.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Points Per Army:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.rb_DuplicateCommonFigures);
            this.groupBox3.Controls.Add(this.rb_DuplicateAll);
            this.groupBox3.Controls.Add(this.rb_NoDuplicates);
            this.groupBox3.Controls.Add(this.rb_DuplicateStandard);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allow Duplicate Figures";
            // 
            // rb_DuplicateCommonFigures
            // 
            this.rb_DuplicateCommonFigures.AutoSize = true;
            this.rb_DuplicateCommonFigures.Location = new System.Drawing.Point(7, 92);
            this.rb_DuplicateCommonFigures.Name = "rb_DuplicateCommonFigures";
            this.rb_DuplicateCommonFigures.Size = new System.Drawing.Size(185, 25);
            this.rb_DuplicateCommonFigures.TabIndex = 3;
            this.rb_DuplicateCommonFigures.Text = "Only Common Figures";
            this.rb_DuplicateCommonFigures.UseVisualStyleBackColor = true;
            // 
            // rb_DuplicateAll
            // 
            this.rb_DuplicateAll.AutoSize = true;
            this.rb_DuplicateAll.Location = new System.Drawing.Point(7, 68);
            this.rb_DuplicateAll.Name = "rb_DuplicateAll";
            this.rb_DuplicateAll.Size = new System.Drawing.Size(101, 25);
            this.rb_DuplicateAll.TabIndex = 2;
            this.rb_DuplicateAll.Text = "All Figures";
            this.rb_DuplicateAll.UseVisualStyleBackColor = true;
            // 
            // rb_NoDuplicates
            // 
            this.rb_NoDuplicates.AutoSize = true;
            this.rb_NoDuplicates.Location = new System.Drawing.Point(7, 44);
            this.rb_NoDuplicates.Name = "rb_NoDuplicates";
            this.rb_NoDuplicates.Size = new System.Drawing.Size(125, 25);
            this.rb_NoDuplicates.TabIndex = 1;
            this.rb_NoDuplicates.Text = "No Duplicates";
            this.rb_NoDuplicates.UseVisualStyleBackColor = true;
            // 
            // rb_DuplicateStandard
            // 
            this.rb_DuplicateStandard.AutoSize = true;
            this.rb_DuplicateStandard.Checked = true;
            this.rb_DuplicateStandard.Location = new System.Drawing.Point(7, 21);
            this.rb_DuplicateStandard.Name = "rb_DuplicateStandard";
            this.rb_DuplicateStandard.Size = new System.Drawing.Size(90, 25);
            this.rb_DuplicateStandard.TabIndex = 0;
            this.rb_DuplicateStandard.TabStop = true;
            this.rb_DuplicateStandard.Text = "Standard";
            this.rb_DuplicateStandard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Settings:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tb_NumPlayers);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 77);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of Players";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(88, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(48, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(166, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(128, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(9, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "2";
            // 
            // tb_NumPlayers
            // 
            this.tb_NumPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.tb_NumPlayers.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tb_NumPlayers.LargeChange = 1;
            this.tb_NumPlayers.Location = new System.Drawing.Point(4, 24);
            this.tb_NumPlayers.Maximum = 6;
            this.tb_NumPlayers.Minimum = 2;
            this.tb_NumPlayers.Name = "tb_NumPlayers";
            this.tb_NumPlayers.Size = new System.Drawing.Size(184, 45);
            this.tb_NumPlayers.TabIndex = 23;
            this.tb_NumPlayers.Value = 2;
            this.tb_NumPlayers.ValueChanged += new System.EventHandler(this.tb_NumPlayers_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox5.Controls.Add(this.nud_Points);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(40, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 61);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Points";
            // 
            // nud_Points
            // 
            this.nud_Points.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_Points.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Points.Location = new System.Drawing.Point(131, 24);
            this.nud_Points.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Points.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Points.Name = "nud_Points";
            this.nud_Points.Size = new System.Drawing.Size(56, 29);
            this.nud_Points.TabIndex = 30;
            this.nud_Points.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Points.ValueChanged += new System.EventHandler(this.nud_Points_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(28, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 505);
            this.panel1.TabIndex = 30;
            // 
            // btn_GenerateArmies
            // 
            this.btn_GenerateArmies.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GenerateArmies.Location = new System.Drawing.Point(396, 119);
            this.btn_GenerateArmies.Name = "btn_GenerateArmies";
            this.btn_GenerateArmies.Size = new System.Drawing.Size(187, 52);
            this.btn_GenerateArmies.TabIndex = 31;
            this.btn_GenerateArmies.Text = "Generate Armies";
            this.btn_GenerateArmies.UseVisualStyleBackColor = true;
            this.btn_GenerateArmies.Click += new System.EventHandler(this.btn_GenerateArmies_Click);
            // 
            // btn_AddPlayer
            // 
            this.btn_AddPlayer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddPlayer.Location = new System.Drawing.Point(14, 279);
            this.btn_AddPlayer.Name = "btn_AddPlayer";
            this.btn_AddPlayer.Size = new System.Drawing.Size(113, 43);
            this.btn_AddPlayer.TabIndex = 32;
            this.btn_AddPlayer.Text = "Add Player";
            this.btn_AddPlayer.UseVisualStyleBackColor = true;
            this.btn_AddPlayer.Click += new System.EventHandler(this.btn_AddPlayer_Click);
            // 
            // btn_RemovePlayer
            // 
            this.btn_RemovePlayer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RemovePlayer.Location = new System.Drawing.Point(136, 279);
            this.btn_RemovePlayer.Name = "btn_RemovePlayer";
            this.btn_RemovePlayer.Size = new System.Drawing.Size(113, 43);
            this.btn_RemovePlayer.TabIndex = 33;
            this.btn_RemovePlayer.Text = "Remove Player";
            this.btn_RemovePlayer.UseVisualStyleBackColor = true;
            this.btn_RemovePlayer.Click += new System.EventHandler(this.btn_RemovePlayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Select the player name and then";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_PlayerList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_RemovePlayer);
            this.panel2.Controls.Add(this.btn_AddPlayer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Reroll);
            this.panel2.Controls.Add(this.btn_ChangeName);
            this.panel2.Location = new System.Drawing.Point(727, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 338);
            this.panel2.TabIndex = 31;
            // 
            // lb_PlayerList
            // 
            this.lb_PlayerList.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PlayerList.FormattingEnabled = true;
            this.lb_PlayerList.ItemHeight = 19;
            this.lb_PlayerList.Location = new System.Drawing.Point(31, 96);
            this.lb_PlayerList.Name = "lb_PlayerList";
            this.lb_PlayerList.Size = new System.Drawing.Size(197, 99);
            this.lb_PlayerList.TabIndex = 32;
            this.lb_PlayerList.SelectedIndexChanged += new System.EventHandler(this.lb_PlayerList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "the desired option for them.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 97);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_FigureFileName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(727, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 141);
            this.panel3.TabIndex = 36;
            // 
            // tb_FigureFileName
            // 
            this.tb_FigureFileName.Enabled = false;
            this.tb_FigureFileName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FigureFileName.Location = new System.Drawing.Point(42, 95);
            this.tb_FigureFileName.Name = "tb_FigureFileName";
            this.tb_FigureFileName.Size = new System.Drawing.Size(181, 23);
            this.tb_FigureFileName.TabIndex = 36;
            this.tb_FigureFileName.Text = "HeroScape_Figure_List.txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "All armies generated will be";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "utilizing figures from this list.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(55, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "Figure List File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1013, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_GenerateArmies);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_MainDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NumPlayers)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Points)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox rtb_MainDisplay;
        private Label label2;
        private Button btn_Reroll;
        private Button btn_ChangeName;
        private GroupBox groupBox2;
        private Label label4;
        private RadioButton rb_DraftRandom;
        private RadioButton rb_DraftSynergy;
        private GroupBox groupBox3;
        private RadioButton rb_NoDuplicates;
        private RadioButton rb_DuplicateStandard;
        private CheckBox cb_AllowHeros;
        private RadioButton rb_DuplicateAll;
        private RadioButton rb_DuplicateCommonFigures;
        private CheckBox cb_AllowSquads;
        private Label label5;
        private GroupBox groupBox4;
        private Label label12;
        private TrackBar tb_NumPlayers;
        private Label label13;
        private Label label16;
        private Label label14;
        private Label label15;
        private GroupBox groupBox5;
        private NumericUpDown nud_Points;
        private Panel panel1;
        private Button btn_GenerateArmies;
        private Button btn_AddPlayer;
        private Button btn_RemovePlayer;
        private Label label3;
        private Panel panel2;
        private Label label6;
        private ListBox lb_PlayerList;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_FigureFileName;
        private PictureBox pictureBox1;
    }
}