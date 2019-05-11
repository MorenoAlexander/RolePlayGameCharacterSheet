using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

//Use custom characters class
using Characters;
namespace RolePlayGameCharacterSheet
{
    public partial class CharacterManager : MetroFramework.Forms.MetroForm
    {
        public CharacterManager()
        {
            InitializeComponent();
        }

        private void CharacterManager_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loading Settings...");
            //var rpgGCSsettings = ConfigurationManager.AppSettings;
            

        }

        private void CreateCharButton_Click(object sender, EventArgs e)
        {
            CreateACharacter CreateCharForm = new CreateACharacter();
            CreateCharForm.Show();
            Program.PreviousPage = this;
            Hide();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
