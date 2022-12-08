using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Real_Life_Simulator.Properties;

namespace Real_Life_Simulator
{
    public partial class BillaCtrl : UserControl
    {
        public BillaCtrl()
        {
            InitializeComponent();
        }

        private void Btn_FruitVegetables_Click(object sender, EventArgs e)
        {
            Pic_Area.Image = Resources.ObstGemüseRegal;
        }
    }
}
