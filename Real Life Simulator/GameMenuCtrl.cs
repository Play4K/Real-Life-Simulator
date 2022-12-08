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
    public partial class Btn_Settings : UserControl
    {
        public Btn_Settings()
        {
            InitializeComponent();
        }

        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            // Sobald neues Spiel gestartet wird, soll in das Panel in Main, das CharacterCreator Fenster geladen werden
            AccountCtrl accountCtrl = new AccountCtrl();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(accountCtrl);

            // wenn das Panel folgendes Fenster beinhaltet, soll das Main Fenster die folgende Fenstergröße haben
            if (Main.mainInstance.PanelContainer.Controls.Contains(accountCtrl))
            {
                //(Breite, Höhe)
                //Main.mainInstance.Size = new Size(670 + 16, 298 + 38);
            }
        }

        private void Btn_ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
