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
    public partial class GameMenuCtrl : UserControl
    {
        public GameMenuCtrl()
        {
            InitializeComponent();
        }

        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            // Sobald neues Spiel gestartet wird, soll in das Panel in Main, das CharacterCreator Fenster geladen werden
            CharacterCreator characterCreatorObj = new CharacterCreator();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(characterCreatorObj);

            // wenn das Panel folgendes Fenster beinhaltet, soll das Main Fenster die folgende Fenstergröße haben
            if (Main.mainInstance.PanelContainer.Controls.Contains(characterCreatorObj))
            {
                //(Breite, Höhe)
                Main.mainInstance.Size = new Size(670 + 16, 298 + 38);
            }
        }

        private void Btn_ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
