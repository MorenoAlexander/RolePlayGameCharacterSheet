using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolePlayGameCharacterSheet
{
    public partial class CreateACharacter : MetroFramework.Forms.MetroForm
    {
        public CreateACharacter()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {


            Program.PreviousPage.Show();
            this.Hide();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "Enter Name")
                metroTextBox1.Clear();
        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {
            if(metroTextBox2.Text == "Race")
            metroTextBox2.Clear();

        }


        //private void MetroText

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateACharacter_Load(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Cha_classTxtBox_Click(object sender, EventArgs e)
        {
            if(cha_classTxtBox.Text == "class")
            {
                cha_classTxtBox.Clear();
            }
        }
        private void Char_skillList_ItemCheck(object sender, EventArgs e)
        {
            
            if (char_skillList.CheckedIndices.Count > 4)
            {
                var dat = char_skillList.CheckedIndices[4];
                //char_skillList.SetItemCheckState(char_skillList.Items.IndexOf(char_skillList.SelectedItem), CheckState.Unchecked);
                char_skillList.SetItemCheckState(dat, CheckState.Unchecked);
            }
        }



        private void Inv_addButton_Click(object sender, EventArgs e)
        {

            if(invItemTextBox.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            string text = invItemTextBox.Text;

            if (invTableLP.RowCount < 50) //Arbitrary max
            {
                invTableLP.RowCount = invTableLP.RowCount + 1;
                invTableLP.RowStyles.Add(new RowStyle(SizeType.AutoSize, 1F));
                invTableLP.Controls.Add(new NumericUpDown() { Value = 1, TextAlign = HorizontalAlignment.Center,MaximumSize= new Size(100,15)}, 1, invTableLP.RowCount - 1);
                invTableLP.Controls.Add(new Label() { Text = text,Dock=DockStyle.Top,Anchor=AnchorStyles.None,TextAlign = ContentAlignment.TopCenter,Font = new Font("Arial",10,FontStyle.Regular),Padding = new Padding(1)}, 2, invTableLP.RowCount - 1);
            }
            
        }

        private void Inv_remove_Click(object sender, EventArgs e)
        {
            int rowCount = invTableLP.RowCount;
            
        }
    }
}
