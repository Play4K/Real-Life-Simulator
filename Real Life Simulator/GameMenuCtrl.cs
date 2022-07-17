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
            CharacterCreator characterCreatorObj = new CharacterCreator();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(characterCreatorObj);
            if (Main.mainInstance.PanelContainer.Controls.Contains(characterCreatorObj))
            {
                Main.mainInstance.Size = new Size(670 + 16, 298 + 38);
            }
        }
    }
}
