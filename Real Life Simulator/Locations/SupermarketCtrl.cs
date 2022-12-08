using System;
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
    public partial class SupermarketCtrl : UserControl
    {
        private MySqlCommand cmd;
        private MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        private MySqlDataReader sqlDataReader;
        private MySqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        private int itemID;
        private string itemName;

        public SupermarketCtrl()
        {
            InitializeComponent();
        }

        private void Supermarket_Load(object sender, EventArgs e)
        {
            ShopAvaibleShopItems();

        }

        private void ShopAvaibleShopItems()
        {
            con.Open();
            sqlDataAdapter = new MySqlDataAdapter($"SELECT * FROM tbl_gameItems WHERE Type IN ('Food', 'Drink')", con);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            Dgv_ShopAvailable.AutoGenerateColumns = false;
            Dgv_ShopAvailable.DataSource = dataTable;
            con.Close();
        }

        private void Dgv_ShopAvailable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ListRow = Dgv_ShopAvailable.SelectedRows;
            var item = new GameItems();
            if (ListRow.Count > 0)
            {
                var row = ListRow[0];
                item.Name = row.Cells[0].Value.ToString();
                item.Type = row.Cells[1].Value.ToString();

                DataGridViewRow dgv_row = (DataGridViewRow)Dgv_Basket.Rows[0].Clone();

                dgv_row.Cells[0].Value = 1;
                dgv_row.Cells[1].Value = item.Name;
                dgv_row.Cells[2].Value = item.Type;
                Dgv_Basket.Rows.Add(dgv_row);

                //if (Dgv_Basket.Rows.Count <= 1)
                //{

                //    dgv_row.Cells[0].Value = 1;
                //    dgv_row.Cells[1].Value = item.Name;
                //    dgv_row.Cells[2].Value = item.Type;
                //    Dgv_Basket.Rows.Add(dgv_row);
                //}
                //else
                //{
                //    foreach (DataGridViewRow dataGridViewRow in Dgv_Basket.Rows)
                //    {
                //        string name = dataGridViewRow.Cells[1].Value.ToString();
                //        if (name == item.Name)
                //        {
                //            MessageBox.Show("Hello");
                //        }
                //        else
                //        {
                //            dgv_row.Cells[0].Value = 1;
                //            dgv_row.Cells[1].Value = item.Name;
                //            dgv_row.Cells[2].Value = item.Type;
                //            Dgv_Basket.Rows.Add(dgv_row);
                //        }
                //    }
                //if (dgv_row.Cells[1].Value.ToString().Contains(item.Name))
                //{
                //    dgv_row.Cells[0].Value = +1;
                //}
                //if (Dgv_Basket.Rows.)
                //else
                //{
                //    
                //}
                //
                //}
            }

            //private void AddItem(GameItems item)
            //{
            //    DataRow row = Dgv_Basket.Rows.
            //    row["Col_Name_Basket"] = item.Name;
            //    row["Col_Type_Basket"] = item.Type;

            //    dataTableShop.Rows.Add(row);
            //}
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            con.Open();
            foreach (DataGridViewRow dr in Dgv_Basket.Rows)
            {
                var ListRow = Dgv_Basket.Rows;
                if(ListRow.Count > 1)
                {
                    //Verhindert das eine leere Celle hinzugefügt wird beim loop
                    if (dr.Cells["Col_Name_Basket"].Value != null)
                    {
                        itemName = dr.Cells["Col_Name_Basket"].Value.ToString();
                        itemID = FindItem();
                        cmd = new MySqlCommand("INSERT INTO tbl_playerinventory VALUES(NULL,@PlayerID,@ItemID,@Name,@Quantity)", con);
                        cmd.Parameters.AddWithValue("@PlayerID", GameSession.choosenPlayerID);
                        cmd.Parameters.AddWithValue("@ItemID", itemID);
                        cmd.Parameters.AddWithValue("@Name", itemName);
                        cmd.Parameters.AddWithValue("@Quantity", 1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item should be added into your inventory", "Item added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No items in the basket.", "No item in basket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            con.Close();
        }

        private int FindItem()
        {
            cmd = new MySqlCommand("SELECT Id FROM tbl_gameitems WHERE Name ='" + itemName + "'", con);
            sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                itemID = (int)sqlDataReader["Id"];
            }
            sqlDataReader.Close();
            return itemID;
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            AccountCtrl accountCtrl = new AccountCtrl();
            accountCtrl.OpenGameWindow();
        }

        private void Btn_RemoveSelectedItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Dgv_Basket.SelectedRows)
            {
                Dgv_Basket.Rows.RemoveAt(item.Index);
            }
        }
    }
}
