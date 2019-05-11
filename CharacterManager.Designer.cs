namespace RolePlayGameCharacterSheet
{
    partial class CharacterManager
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
            this.CreateCharButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.CharacterList = new System.Windows.Forms.ListBox();
            this.changeDefaultFolder = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCharButton
            // 
            this.CreateCharButton.Location = new System.Drawing.Point(23, 63);
            this.CreateCharButton.Name = "CreateCharButton";
            this.CreateCharButton.Size = new System.Drawing.Size(139, 23);
            this.CreateCharButton.TabIndex = 0;
            this.CreateCharButton.Text = "New Character";
            this.CreateCharButton.UseSelectable = true;
            this.CreateCharButton.Click += new System.EventHandler(this.CreateCharButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 92);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(139, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Load Char File";
            this.metroButton2.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeDefaultFolder);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.CharacterList);
            this.panel1.Location = new System.Drawing.Point(568, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 364);
            this.panel1.TabIndex = 5;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(112, 312);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Delete";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(3, 312);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "Load";
            this.metroButton4.UseSelectable = true;
            // 
            // CharacterList
            // 
            this.CharacterList.FormattingEnabled = true;
            this.CharacterList.Items.AddRange(new object[] {
            "Blank",
            "Ddd"});
            this.CharacterList.Location = new System.Drawing.Point(3, 29);
            this.CharacterList.Name = "CharacterList";
            this.CharacterList.Size = new System.Drawing.Size(184, 277);
            this.CharacterList.TabIndex = 0;
            // 
            // changeDefaultFolder
            // 
            this.changeDefaultFolder.Location = new System.Drawing.Point(3, 3);
            this.changeDefaultFolder.Name = "changeDefaultFolder";
            this.changeDefaultFolder.Size = new System.Drawing.Size(107, 23);
            this.changeDefaultFolder.TabIndex = 7;
            this.changeDefaultFolder.Text = "Change Directory";
            this.changeDefaultFolder.UseSelectable = true;
            // 
            // CharacterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.CreateCharButton);
            this.Name = "CharacterManager";
            this.Text = "CharacterManager";
            this.Load += new System.EventHandler(this.CharacterManager_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton CreateCharButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.ListBox CharacterList;
        private MetroFramework.Controls.MetroButton changeDefaultFolder;
    }
}

