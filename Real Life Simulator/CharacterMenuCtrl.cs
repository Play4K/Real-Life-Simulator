using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities.Collections;

namespace Real_Life_Simulator
{
    public partial class CharacterMenuCtrl : UserControl, INotifyPropertyChanged
    {
        private MySqlCommand cmd;
        private MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        private MySqlDataReader sqlDataReader;

        Color color;

        public CharacterMenuCtrl()
        {
            InitializeComponent();
            DataBindingPlayerStats();
            SQLConnection sqlConnection = new SQLConnection();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void CharacterMenuCtrl_Load(object sender, EventArgs e)
        {
            //DataBindingPlayerStats();
            Lbl_Clock.DataBindings.Add("Text", GameSession.gameSession, "DateTime");
        }

        public void DataBindingPlayerStats()
        {
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_players WHERE Id='" + GameSession.choosenPlayerID + "'", con);
            sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string firstName = sqlDataReader["FirstName"].ToString();
                string lastName = sqlDataReader["LastName"].ToString();
                string fullName = firstName + " " + lastName;

                Lbl_Name.Text = fullName;
                Lbl_Age.Text = sqlDataReader["Age"].ToString();
                Lbl_Gender.Text = sqlDataReader["Gender"].ToString();
                Lbl_Balance.Text = sqlDataReader["Balance"].ToString();
                Lbl_Job.Text = sqlDataReader["Job"].ToString();
                Pbr_Hunger.Value = Convert.ToInt32(sqlDataReader["Hunger"]);
                Pbr_Thirst.Value = Convert.ToInt32(sqlDataReader["Thirst"]);
                Pbr_Energy.Value = Convert.ToInt32(sqlDataReader["Energy"]);
            }
            sqlDataReader.Close();
        }

        private void Pnl_Shoes_MouseDown(object sender, MouseEventArgs e)
        {
            Pnl_Shoes.BackColor = Color.Gainsboro;
        }

        private void Pnl_Shoes_MouseUp(object sender, MouseEventArgs e)
        {
            Pnl_Shoes.BackColor = Color.Silver;
        }

        private void OpenFile(Panel chosenPanel)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image FIles(*.jpg; *.jpeg; *.png|*.jpg; *jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (chosenPanel != null)
                {
                    chosenPanel.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    chosenPanel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void ShowChosenItemInformation()
        {

        }

        private void Pnl_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    break;
                case MouseButtons.Right:
                    var chosenPanel = sender as Panel;
                    FontFamily fontFamily = new FontFamily("Segoe UI");
                    Font font = new Font(fontFamily, 10, FontStyle.Regular);

                    var Lbx_RightMouseClickPnl = new ListBox()
                    {
                        BackColor = Color.Silver,
                        BorderStyle = BorderStyle.Fixed3D,
                        Name = "Lbx",
                        Size = new Size(120, 72),
                        Location = new Point(chosenPanel.Location.X - 123, chosenPanel.Location.Y),
                        Font = font,
                    };

                    Lbx_RightMouseClickPnl.SuspendLayout();
                    Lbx_RightMouseClickPnl.Items.Add("Change wear");
                    Lbx_RightMouseClickPnl.Items.Add("Take off");
                    this.Controls.Add(Lbx_RightMouseClickPnl);

                    Lbx_RightMouseClickPnl.MouseClick += (lbxSender, lbxE) =>
                    {
                        ListBoxClickEvent(lbxSender, chosenPanel);
                    };
                    break;
            }

            //AB HIER SOLL DER CODE FÜR DIE ITEM ANZEIGE INFORMATION STEHEN, beim CLICK

        }

        private void ListBoxClickEvent(object sender, Panel chosenPanel)
        {
            if (sender is ListBox listBox)
            {
                if (listBox.SelectedItem.ToString() == "Change wear")
                {
                    OpenFile(chosenPanel);
                    this.Controls.Remove(listBox);
                }
                else if (listBox.SelectedItem.ToString() == "Take off")
                {
                    chosenPanel.BackgroundImage = null;
                    this.Controls.Remove(listBox);
                }
            }
        }

        public void UpdateEnergy()
        {
            try
            {
                SQLConnection sqlConnection = new SQLConnection();
                sqlConnection.con.Open();
                sqlConnection.cmd = new MySqlCommand("SELECT * FROM tbl_players SET Energy = '" + GameSession.gameSession.currentPlayer.Energy + "' WHERE AccountID = '" + GameSession.connectedAccountID + "' AND Id = '" + GameSession.choosenPlayerID + "'", sqlConnection.con);
                sqlConnection.sqlDataReader = sqlConnection.cmd.ExecuteReader();
                if (sqlConnection.sqlDataReader.Read())
                {
                    GameSession.gameSession.currentPlayer.Energy = Convert.ToDouble(sqlConnection.sqlDataReader["Energy"]);
                    sqlConnection.sqlDataReader.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
