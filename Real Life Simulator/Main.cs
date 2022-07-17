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
    public partial class Main : Form
    {
        public static Main mainInstance = null;

        public Main()
        {
            if (mainInstance != null)
            {
                return;
            }
            mainInstance = this;
            
            InitializeComponent();
        }

        
        //Panel mainPanel = new Panel();

        private void Main_Load(object sender, EventArgs e)
        {
            mainInstance.StartPosition = FormStartPosition.CenterScreen;
            GameMenuCtrl gameMenuCtrl = new GameMenuCtrl();
            Pn_Main.Controls.Add(gameMenuCtrl);
            gameMenuCtrl.Show();
        }

        public Panel PanelContainer
        {
            get { return Pn_Main; }
            set { Pn_Main = value; }
        }
    }
}
