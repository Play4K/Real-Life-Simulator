using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public partial class CharacterCreator : UserControl
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        private void CharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            if (Txt_FirstName.Text != "" && Txt_LastName.Text != "" && Lbx_Gender.SelectedIndex >= 0)
            {
                CharacterCreated();

                // CharacterCreator Fenster (das jetzige) soll sich schließen
                this.Hide();

                // Ins Pnl_Container von Main soll ein bestimmtes Fenster geladen werden
                GameWindowCtrl gameWindowCtrl = new GameWindowCtrl();
                Main.mainInstance.PanelContainer.Controls.Clear();
                Main.mainInstance.PanelContainer.Controls.Add(gameWindowCtrl);
            }
        }

        private void CharacterCreated()
        {
            //Wenn der Character erstellt wurde, soll folgende Eigenschaften übernommen werden
            GameSession.CurrentPlayer.FirstName = Txt_FirstName.Text;
            GameSession.CurrentPlayer.LastName = Txt_LastName.Text;
            GameSession.CurrentPlayer.Age = 14;
            if (Lbx_Gender.SelectedItem.Equals("Male"))
            {
                GameSession.CurrentPlayer.Gender = "Male";
            }
            else
            {
                GameSession.CurrentPlayer.Gender = "Female";
            }

            GameSession.CurrentPlayer.Health = 80;
            GameSession.CurrentPlayer.Hunger = 80;
            GameSession.CurrentPlayer.Thirst = 80;
            GameSession.CurrentPlayer.Energy = 80;
            GameSession.CurrentPlayer.Balance = 10;
        }
    }
}
