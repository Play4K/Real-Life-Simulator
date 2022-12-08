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
    public partial class CityMap1 : UserControl
    {
        public CityMap1()
        {
            InitializeComponent();
        }

        private void CityMap1_Load(object sender, EventArgs e)
        {
            Main.mainInstance.Size = new Size(830 + 16, 1095 + 38);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_CharacterMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameWindow characterMenuObj = new GameWindow();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(characterMenuObj);
        }
    }
}
