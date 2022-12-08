using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public partial class ItemCreator : Form
    {
        private MySqlCommand cmd;
        private MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        private MySqlDataReader sqlDataReader;
        private MySqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        private DataSet dataSet;
        private DataGrid dataGrid;


        public ItemCreator()
        {
            InitializeComponent();
        }

        private void ItemCreator_Load(object sender, EventArgs e)
        {

        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void AddItem()
        {
            con.Open();
            cmd = new MySqlCommand("INSERT INTO tbl_gameItems VALUES(@Id, @Type, @Name, @Value, @Gender, @Health, @Thirst, @Hunger, @Energy, @Strength, @Defense)", con);
            cmd.Parameters.AddWithValue("@Id", Txt_Add_ID.Text);
            cmd.Parameters.AddWithValue("@Type", Cbx_Add_Type.SelectedItem);
            cmd.Parameters.AddWithValue("@Name", Txt_Add_Name.Text);
            cmd.Parameters.AddWithValue("@Value", Txt_Add_Value.Text);
            cmd.Parameters.AddWithValue("@Gender", Cbx_Add_Gender.SelectedItem);
            cmd.Parameters.AddWithValue("@Health", Txt_Add_Health.Text);
            cmd.Parameters.AddWithValue("@Thirst", Txt_Add_Thirst.Text);
            cmd.Parameters.AddWithValue("@Hunger", Txt_Add_Hunger.Text);
            cmd.Parameters.AddWithValue("@Energy", Txt_Add_Energy.Text);
            cmd.Parameters.AddWithValue("@Strength", Txt_Add_Strength.Text);
            cmd.Parameters.AddWithValue("@Defense", Txt_Add_Defense.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item successfull added into Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditItem()
        {

        }

        private void DeleteItem()
        {

        }

        private void Btn_UpdateDatabase_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_gameItems", con);
            sqlDataAdapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Dgv_GameItems.DataSource = dataTable;
            con.Close();
        }
    }
}
