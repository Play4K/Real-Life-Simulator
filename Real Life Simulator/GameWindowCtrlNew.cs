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
    public partial class GameWindowCtrlNew : UserControl
    {
        public GameWindowCtrlNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charakter Menu öffnet sich in Pnl_Container von GameWindow
        /// </summary>
        private void Btn_Character_Click(object sender, EventArgs e)
        {
            CharacterMenuCtrl characterMenuCtrl = new CharacterMenuCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(characterMenuCtrl);
        }
    }
}
