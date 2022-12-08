using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public partial class InventoryCtrl : UserControl
    {
        private MySqlCommand cmd;
        private MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        private MySqlDataReader sqlDataReader;
        private MySqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        DataTable dataTable2 = new DataTable();

        public InventoryCtrl()
        {
            InitializeComponent();
        }

        private void InventoryCtrl_Load(object sender, EventArgs e)
        {
            ShowPlayerInventory();

            
            
        }

        private void Btn_UpdateDatabase_Click(object sender, EventArgs e)
        {
            ItemCreator itemCreator = new ItemCreator();
            itemCreator.Show();
        }

        private void ShowPlayerInventory()
        {
            con.Open();
            sqlDataAdapter = new MySqlDataAdapter("SELECT * FROM tbl_playerinventory WHERE PlayerID ='" + GameSession.choosenPlayerID + "'", con);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            Dgv_InventoryItems.DataSource = dataTable;
            con.Close();
        }

        private void Dgv_InventoryItems_Click(object sender, EventArgs e)
        {
            var ListRow = Dgv_InventoryItems.SelectedRows;
            if (ListRow.Count > 0)
            {
                var row = ListRow[0];
                int itemID = (int)row.Cells["ItemID"].Value;

                con.Open();
                sqlDataAdapter = new MySqlDataAdapter("SELECT * FROM tbl_gameItems WHERE Id ='" + itemID + "'", con);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                DataTable dataTable2 = new DataTable();

                dataTable2.Columns.Add(".");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable2.Columns.Add();
                }
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    DataRow newRow = dataTable2.NewRow();

                    newRow[0] = dataTable.Columns[i].Caption;
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        newRow[j + 1] = dataTable.Rows[j][i];
                    }
                    dataTable2.Rows.Add(newRow);
                }
                con.Close();
                //sqlDataAdapter.Fill(dataTable2);

                //Dgv_SelectedItemInformation.AutoGenerateColumns = false;
                Dgv_SelectedItemInformation.DataSource = dataTable2;
            }
        }
    }
}
