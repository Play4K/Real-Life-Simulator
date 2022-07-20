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
    public partial class GameWindowCtrl : UserControl
    {
        // Objekte von den Fenster werden daweil mal gleich hier "erstellt", noch nicht zugewiesen
        CharacterMenuCtrl characterMenuCtrl = null;
        InventoryCtrl inventoryCtrl = null;

        public GameWindowCtrl()
        {
            InitializeComponent();
        }

        // Charakter Menu öffnet sich in Pnl_Container von GameWindow
        private void Btn_Character_Click(object sender, EventArgs e)
        {
            // Ins Pnl_Container soll ein bestimmtes Fenster geladen werden
            CharacterMenuCtrl characterMenuCtrl = new CharacterMenuCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(characterMenuCtrl);
        }

        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            // Ins Pnl_Container soll ein bestimmtes Fenster geladen werden
            InventoryCtrl inventoryCtrl = new InventoryCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(inventoryCtrl);
        }

        private void GameWindowCtrl_Load(object sender, EventArgs e)
        {
            // Ins Pnl_Container soll ein bestimmtes Fenster geladen werden
            characterMenuCtrl = new CharacterMenuCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(characterMenuCtrl);

            //Fenstergröße soll eingestellt werden, wenn GameWindow geladen wird
            Main.mainInstance.WindowsPreset();
        }
    }
}
