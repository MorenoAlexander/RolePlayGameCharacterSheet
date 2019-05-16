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

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateACharacter_Load(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
