using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerticalProgressBar;

namespace Real_Life_Simulator
{
    public partial class GameWindow : UserControl, INotifyPropertyChanged
    {

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

            Main.mainInstance.Size = new Size(900 + 16, 700 + 38);
            DataBindingPlayerStats();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Pn_Map_Click(object sender, EventArgs e)
        {
            CityMap1 cityMap1Obj = new CityMap1();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(cityMap1Obj);
        }

        public void DataBindingPlayerStats()
        {
            Lbl_Name.DataBindings.Add("Text", GameSession.CurrentPlayer, "FullName");
            Lbl_Age.DataBindings.Add("Text", GameSession.CurrentPlayer, "Age");
            Lbl_Gender.DataBindings.Add("Text", GameSession.CurrentPlayer, "Gender");
            Lbl_Balance.DataBindings.Add("Text", GameSession.CurrentPlayer, "Balance");
            Pbr_Health.Value = GameSession.CurrentPlayer.Health;
            Pbr_Hunger.Value = GameSession.CurrentPlayer.Hunger;
            Pbr_Thirst.Value = GameSession.CurrentPlayer.Thirst;
        }
    }
}
