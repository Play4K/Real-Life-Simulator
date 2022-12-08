using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public partial class AccountCtrl : UserControl
    {
        //private string Connection = @"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator";

        private static MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        private MySqlCommand cmd;
        private MySqlDataReader sqlDataReader;
        private MySqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        public AccountCtrl()
        {
            InitializeComponent();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            if (Txt_FirstName.Text != "" && Txt_LastName.Text != "" && Lbx_Gender.SelectedIndex >= 0)
            {
                Register();
            }
        }

        public void OpenGameWindow()
        {
            this.Hide();
            GameWindowCtrl gameWindowCtrl = new GameWindowCtrl();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(gameWindowCtrl);
        }

        private void Register()
        {
            if (Txt_Username.Text != string.Empty && Txt_Password.Text != string.Empty && Txt_RPassword.Text != string.Empty)
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM tbl_accounts WHERE Username='" + Txt_Username.Text + "'", con);
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    MessageBox.Show("Choose another Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlDataReader.Dispose();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_accounts VALUES(NULL,@Username,@Password)", con);
                    cmd.Parameters.AddWithValue("@Username", Txt_Username.Text);
                    cmd.Parameters.AddWithValue("@Password", Txt_Password.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is successful created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill out all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login()
        {
            if (Txt_Username.Text != string.Empty || Txt_Password.Text != string.Empty)
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM tbl_accounts WHERE Username='" + Txt_Username.Text + "' AND Password='" + Txt_Password.Text + "'", con);
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Pnl_Character.Enabled = true;
                    GameSession.connectedAccountID = Convert.ToInt32(sqlDataReader["Id"]);
                    Lbl_connectedAccountID.Text = "AccountID: " + GameSession.connectedAccountID.ToString();
                    MessageBox.Show("Connected to account.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlDataReader.Close();
                    ShowAvailableCharacter();
                    con.Close();
                }
                else
                {
                    sqlDataReader.Close();
                    con.Close();
                    MessageBox.Show("No Account has been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlDataReader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill out all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAvailableCharacter()
        {
            sqlDataAdapter = new MySqlDataAdapter("SELECT * FROM tbl_players WHERE AccountID='" + GameSession.connectedAccountID + "'", con);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlDataReader.Close();

            Dgv_Character.AutoGenerateColumns = false;
            Dgv_Character.DataSource = dataTable;
        }

        private void Btn_LoginRegister_Click(object sender, EventArgs e)
        {
            if (Cbx_Register.Checked == true)
            {
                Register();
                
            }
            else
            {
                Login();
            }
        }

        private void Cbx_Register_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Register.Checked == true)
            {
                Txt_RPassword.Visible = true;
                Lbl_RPassword.Visible = true;
                Txt_Password.PasswordChar = (char)0;
                Btn_LoginRegister.Text = "Register";

            }
            else
            {
                Txt_RPassword.Visible = false;
                Lbl_RPassword.Visible = false;
                Txt_Password.PasswordChar = '*';
                Btn_LoginRegister.Text = "LogIn";
            }
        }

        private void Btn_CreatePlayer_Click(object sender, EventArgs e)
        {
            con.Open();
            if (Txt_FirstName.Text != string.Empty && Txt_LastName.Text != string.Empty && Lbx_Gender.SelectedItem.ToString() != "")
            {
                sqlDataReader.Close();
                cmd = new MySqlCommand("INSERT INTO tbl_players VALUES(NULL,@AccountID,@FirstName,@LastName,@Gender,@Age,@Balance,@Job,@Health,@Hunger,@Thirst,@Energy)", con);
                cmd.Parameters.AddWithValue("@AccountID", GameSession.connectedAccountID);
                cmd.Parameters.AddWithValue("@FirstName", Txt_FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", Txt_LastName.Text);
                cmd.Parameters.AddWithValue("@Gender", Lbx_Gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Age", 18);
                cmd.Parameters.AddWithValue("@Balance", 1000);
                cmd.Parameters.AddWithValue("@Job", "Jobless");
                cmd.Parameters.AddWithValue("@Health", 100);
                cmd.Parameters.AddWithValue("@Hunger", 100);
                cmd.Parameters.AddWithValue("@Thirst", 100);
                cmd.Parameters.AddWithValue("@Energy", 100);
                cmd.ExecuteNonQuery();
                ShowAvailableCharacter();
                MessageBox.Show("Player successful created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlDataReader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill out all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ChooseCharacter_Click(object sender, EventArgs e)
        {
            var listRow = Dgv_Character.SelectedRows;
            if (listRow.Count > 0)
            {
                var row = listRow[0];
                GameSession.choosenPlayerID = (int)row.Cells[0].Value;
                OpenGameWindow();
            }
        }

        private void Cbx_Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Admin.Checked == true)
            {
                Txt_Username.Text = "Play4K";
                Txt_Password.Text = "pvpbb159";
            }
            else
            {
                Txt_Username.Text = String.Empty;
                Txt_Password.Text = String.Empty;
            }
        }
    }
}
