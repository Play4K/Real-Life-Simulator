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
        // Von "Main" wird ein Objekt "erstellt", aber noch nicht zugewiesen (damit man auf die Elemente von "Main" zugreifen kann, wird das gemacht)
        public static Main mainInstance = null;

        //Fenstergröße Voreinstellung
        public int WindowsWidth = 1920;
        public int WindowsHeight = 1080;

        public Main()
        {
            // hier wird das Fenster "Main" auf das Objekt mainInstance was davor erstellt wurde, "zugewiesen" (jetzt kann man auf die Elemente von "Main" außerhalb "Main" Klasse zugreifen)
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
            StartPosition = FormStartPosition.CenterScreen;
            GameMenuCtrl gameMenuCtrl = new GameMenuCtrl();
            Main.mainInstance.Size = new Size(670 + 16, 298 + 38);
            Pnl_Main.Controls.Add(gameMenuCtrl);
            gameMenuCtrl.Show();
        }

        public Panel PanelContainer
        {
            get { return Pnl_Main; }
            set { Pnl_Main = value; }
        }

        public void WindowsPreset()
        {
            this.Size = new Size(WindowsWidth, WindowsHeight);
        }
    }
}
