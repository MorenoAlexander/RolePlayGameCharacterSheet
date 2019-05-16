﻿namespace RolePlayGameCharacterSheet
{
    partial class CreateACharacter
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
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.CreateButton = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.lbl_name = new MetroFramework.Controls.MetroLabel();
            this.lbl_race = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.char_skillList = new System.Windows.Forms.CheckedListBox();
            this.char_statpanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_dex = new System.Windows.Forms.Label();
            this.lbl_const = new System.Windows.Forms.Label();
            this.lbl_wis = new System.Windows.Forms.Label();
            this.lbl_cha = new System.Windows.Forms.Label();
            this.lbl_str = new System.Windows.Forms.Label();
            this.lbl_int = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_class_prompt = new MetroFramework.Controls.MetroLabel();
            this.lbl_lvl = new MetroFramework.Controls.MetroLabel();
            this.cha_lvlnumber = new System.Windows.Forms.NumericUpDown();
            this.cha_classTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.char_statpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cha_lvlnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(667, 423);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(559, 423);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(102, 23);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Enter Name"};
            this.metroTextBox1.Location = new System.Drawing.Point(68, 66);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "Enter Name";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.NameTextBox_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(17, 66);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 19);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // lbl_race
            // 
            this.lbl_race.AutoSize = true;
            this.lbl_race.Location = new System.Drawing.Point(17, 95);
            this.lbl_race.Name = "lbl_race";
            this.lbl_race.Size = new System.Drawing.Size(37, 19);
            this.lbl_race.TabIndex = 5;
            this.lbl_race.Text = "Race";
            this.lbl_race.Click += new System.EventHandler(this.MetroLabel2_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Race"};
            this.metroTextBox2.Location = new System.Drawing.Point(68, 95);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.Text = "Race";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.Click += new System.EventHandler(this.MetroTextBox2_Click);
            // 
            // char_skillList
            // 
            this.char_skillList.FormattingEnabled = true;
            this.char_skillList.Items.AddRange(new object[] {
            "Acrobatics (Dex)",
            "Animal Handling (Wis)",
            "Arcana (Int)",
            "Athletics (Str)",
            "Deception (Cha)",
            "History (Int)",
            "Insight (Wis)",
            "Intimidation (Cha)",
            "Investigation (Int)",
            "Medicine (Wis)",
            "Nature (Int)",
            "Perception (Wis)",
            "Performance (Cha)",
            "Persuasion (Cha)",
            "Religion (Int)",
            "Sleight of Hand (Dex)",
            "Stealth (Dex)",
            "Survival (Wis)"});
            this.char_skillList.Location = new System.Drawing.Point(193, 124);
            this.char_skillList.Margin = new System.Windows.Forms.Padding(1);
            this.char_skillList.Name = "char_skillList";
            this.char_skillList.Size = new System.Drawing.Size(128, 274);
            this.char_skillList.TabIndex = 6;
            // 
            // char_statpanel
            // 
            this.char_statpanel.ColumnCount = 3;
            this.char_statpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.char_statpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.char_statpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.char_statpanel.Controls.Add(this.lbl_dex, 0, 1);
            this.char_statpanel.Controls.Add(this.lbl_const, 0, 2);
            this.char_statpanel.Controls.Add(this.lbl_wis, 0, 4);
            this.char_statpanel.Controls.Add(this.lbl_cha, 0, 5);
            this.char_statpanel.Controls.Add(this.lbl_str, 0, 0);
            this.char_statpanel.Controls.Add(this.lbl_int, 0, 3);
            this.char_statpanel.Controls.Add(this.numericUpDown2, 1, 0);
            this.char_statpanel.Controls.Add(this.numericUpDown3, 1, 1);
            this.char_statpanel.Controls.Add(this.numericUpDown4, 1, 2);
            this.char_statpanel.Controls.Add(this.numericUpDown5, 1, 3);
            this.char_statpanel.Controls.Add(this.numericUpDown6, 1, 4);
            this.char_statpanel.Controls.Add(this.numericUpDown7, 1, 5);
            this.char_statpanel.Controls.Add(this.numericUpDown8, 2, 0);
            this.char_statpanel.Controls.Add(this.numericUpDown9, 2, 1);
            this.char_statpanel.Controls.Add(this.numericUpDown10, 2, 2);
            this.char_statpanel.Controls.Add(this.numericUpDown11, 2, 3);
            this.char_statpanel.Controls.Add(this.numericUpDown12, 2, 5);
            this.char_statpanel.Controls.Add(this.numericUpDown13, 2, 4);
            this.char_statpanel.Location = new System.Drawing.Point(17, 124);
            this.char_statpanel.Name = "char_statpanel";
            this.char_statpanel.RowCount = 6;
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.char_statpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.char_statpanel.Size = new System.Drawing.Size(172, 156);
            this.char_statpanel.TabIndex = 7;
            this.char_statpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // lbl_dex
            // 
            this.lbl_dex.AutoSize = true;
            this.lbl_dex.Location = new System.Drawing.Point(3, 20);
            this.lbl_dex.Name = "lbl_dex";
            this.lbl_dex.Size = new System.Drawing.Size(48, 13);
            this.lbl_dex.TabIndex = 8;
            this.lbl_dex.Text = "Dexterity";
            // 
            // lbl_const
            // 
            this.lbl_const.AutoSize = true;
            this.lbl_const.Location = new System.Drawing.Point(3, 40);
            this.lbl_const.Name = "lbl_const";
            this.lbl_const.Size = new System.Drawing.Size(62, 13);
            this.lbl_const.TabIndex = 9;
            this.lbl_const.Text = "Constitution";
            // 
            // lbl_wis
            // 
            this.lbl_wis.AutoSize = true;
            this.lbl_wis.Location = new System.Drawing.Point(3, 80);
            this.lbl_wis.Name = "lbl_wis";
            this.lbl_wis.Size = new System.Drawing.Size(45, 13);
            this.lbl_wis.TabIndex = 11;
            this.lbl_wis.Text = "Wisdom";
            // 
            // lbl_cha
            // 
            this.lbl_cha.AutoSize = true;
            this.lbl_cha.Location = new System.Drawing.Point(3, 100);
            this.lbl_cha.Name = "lbl_cha";
            this.lbl_cha.Size = new System.Drawing.Size(50, 13);
            this.lbl_cha.TabIndex = 12;
            this.lbl_cha.Text = "Charisma";
            // 
            // lbl_str
            // 
            this.lbl_str.AutoSize = true;
            this.lbl_str.Location = new System.Drawing.Point(3, 0);
            this.lbl_str.Name = "lbl_str";
            this.lbl_str.Size = new System.Drawing.Size(47, 13);
            this.lbl_str.TabIndex = 0;
            this.lbl_str.Text = "Strength";
            // 
            // lbl_int
            // 
            this.lbl_int.AutoSize = true;
            this.lbl_int.Location = new System.Drawing.Point(3, 60);
            this.lbl_int.Name = "lbl_int";
            this.lbl_int.Size = new System.Drawing.Size(61, 13);
            this.lbl_int.TabIndex = 10;
            this.lbl_int.Text = "Intelligence";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(71, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(71, 23);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown3.TabIndex = 26;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(71, 43);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown4.TabIndex = 27;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(71, 63);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown5.TabIndex = 28;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(71, 83);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown6.TabIndex = 29;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(71, 103);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown7.TabIndex = 30;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(130, 3);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown8.TabIndex = 31;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(130, 23);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown9.TabIndex = 32;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(130, 43);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown10.TabIndex = 33;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(130, 63);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown11.TabIndex = 34;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(130, 103);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown12.TabIndex = 35;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(130, 83);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown13.TabIndex = 36;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.randomToolStripMenuItem.Text = "random";
            // 
            // lbl_class_prompt
            // 
            this.lbl_class_prompt.AutoSize = true;
            this.lbl_class_prompt.Location = new System.Drawing.Point(149, 70);
            this.lbl_class_prompt.Name = "lbl_class_prompt";
            this.lbl_class_prompt.Size = new System.Drawing.Size(38, 19);
            this.lbl_class_prompt.TabIndex = 9;
            this.lbl_class_prompt.Text = "Class";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(150, 98);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(38, 19);
            this.lbl_lvl.TabIndex = 10;
            this.lbl_lvl.Text = "Level";
            // 
            // cha_lvlnumber
            // 
            this.cha_lvlnumber.Location = new System.Drawing.Point(193, 97);
            this.cha_lvlnumber.Name = "cha_lvlnumber";
            this.cha_lvlnumber.Size = new System.Drawing.Size(38, 20);
            this.cha_lvlnumber.TabIndex = 11;
            // 
            // cha_classTxtBox
            // 
            // 
            // 
            // 
            this.cha_classTxtBox.CustomButton.Image = null;
            this.cha_classTxtBox.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.cha_classTxtBox.CustomButton.Name = "";
            this.cha_classTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cha_classTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cha_classTxtBox.CustomButton.TabIndex = 1;
            this.cha_classTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cha_classTxtBox.CustomButton.UseSelectable = true;
            this.cha_classTxtBox.CustomButton.Visible = false;
            this.cha_classTxtBox.Lines = new string[] {
        "class"};
            this.cha_classTxtBox.Location = new System.Drawing.Point(193, 68);
            this.cha_classTxtBox.MaxLength = 32767;
            this.cha_classTxtBox.Name = "cha_classTxtBox";
            this.cha_classTxtBox.PasswordChar = '\0';
            this.cha_classTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cha_classTxtBox.SelectedText = "";
            this.cha_classTxtBox.SelectionLength = 0;
            this.cha_classTxtBox.SelectionStart = 0;
            this.cha_classTxtBox.ShortcutsEnabled = true;
            this.cha_classTxtBox.Size = new System.Drawing.Size(128, 23);
            this.cha_classTxtBox.TabIndex = 12;
            this.cha_classTxtBox.Text = "class";
            this.cha_classTxtBox.UseSelectable = true;
            this.cha_classTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cha_classTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // CreateACharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.cha_classTxtBox);
            this.Controls.Add(this.cha_lvlnumber);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_class_prompt);
            this.Controls.Add(this.char_statpanel);
            this.Controls.Add(this.char_skillList);
            this.Controls.Add(this.lbl_race);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "CreateACharacter";
            this.Text = "Create new Character";
            this.Load += new System.EventHandler(this.CreateACharacter_Load);
            this.char_statpanel.ResumeLayout(false);
            this.char_statpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cha_lvlnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroButton CreateButton;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel lbl_name;
        private MetroFramework.Controls.MetroLabel lbl_race;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.CheckedListBox char_skillList;
        private System.Windows.Forms.TableLayoutPanel char_statpanel;
        private System.Windows.Forms.Label lbl_dex;
        private System.Windows.Forms.Label lbl_str;
        private System.Windows.Forms.Label lbl_const;
        private System.Windows.Forms.Label lbl_wis;
        private System.Windows.Forms.Label lbl_cha;
        private System.Windows.Forms.Label lbl_int;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lbl_class_prompt;
        private MetroFramework.Controls.MetroLabel lbl_lvl;
        private System.Windows.Forms.NumericUpDown cha_lvlnumber;
        private MetroFramework.Controls.MetroTextBox cha_classTxtBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}