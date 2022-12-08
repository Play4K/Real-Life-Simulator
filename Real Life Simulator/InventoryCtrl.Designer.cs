namespace Real_Life_Simulator
{
    partial class InventoryCtrl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tctrl_Inventory = new System.Windows.Forms.TabControl();
            this.Tpg_Inventory1 = new System.Windows.Forms.TabPage();
            this.Dgv_InventoryItems = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dgv_SelectedItemInformation = new System.Windows.Forms.DataGridView();
            this.Btn_UpdateDatabase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tctrl_Inventory.SuspendLayout();
            this.Tpg_Inventory1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InventoryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SelectedItemInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // Tctrl_Inventory
            // 
            this.Tctrl_Inventory.Controls.Add(this.Tpg_Inventory1);
            this.Tctrl_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tctrl_Inventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tctrl_Inventory.Location = new System.Drawing.Point(0, 0);
            this.Tctrl_Inventory.Name = "Tctrl_Inventory";
            this.Tctrl_Inventory.SelectedIndex = 0;
            this.Tctrl_Inventory.Size = new System.Drawing.Size(1920, 1020);
            this.Tctrl_Inventory.TabIndex = 1;
            // 
            // Tpg_Inventory1
            // 
            this.Tpg_Inventory1.BackColor = System.Drawing.Color.Gainsboro;
            this.Tpg_Inventory1.Controls.Add(this.Dgv_InventoryItems);
            this.Tpg_Inventory1.Controls.Add(this.dataGridView1);
            this.Tpg_Inventory1.Controls.Add(this.Dgv_SelectedItemInformation);
            this.Tpg_Inventory1.Controls.Add(this.Btn_UpdateDatabase);
            this.Tpg_Inventory1.Controls.Add(this.label3);
            this.Tpg_Inventory1.Controls.Add(this.label2);
            this.Tpg_Inventory1.Controls.Add(this.label1);
            this.Tpg_Inventory1.Controls.Add(this.button13);
            this.Tpg_Inventory1.Controls.Add(this.button10);
            this.Tpg_Inventory1.Controls.Add(this.button11);
            this.Tpg_Inventory1.Controls.Add(this.button12);
            this.Tpg_Inventory1.Controls.Add(this.button7);
            this.Tpg_Inventory1.Controls.Add(this.button8);
            this.Tpg_Inventory1.Controls.Add(this.button9);
            this.Tpg_Inventory1.Controls.Add(this.button4);
            this.Tpg_Inventory1.Controls.Add(this.button5);
            this.Tpg_Inventory1.Controls.Add(this.button6);
            this.Tpg_Inventory1.Controls.Add(this.button3);
            this.Tpg_Inventory1.Controls.Add(this.button2);
            this.Tpg_Inventory1.Controls.Add(this.button1);
            this.Tpg_Inventory1.Location = new System.Drawing.Point(4, 26);
            this.Tpg_Inventory1.Name = "Tpg_Inventory1";
            this.Tpg_Inventory1.Padding = new System.Windows.Forms.Padding(3);
            this.Tpg_Inventory1.Size = new System.Drawing.Size(1912, 990);
            this.Tpg_Inventory1.TabIndex = 0;
            this.Tpg_Inventory1.Text = "Inventory 1";
            // 
            // Dgv_InventoryItems
            // 
            this.Dgv_InventoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InventoryItems.Location = new System.Drawing.Point(354, 105);
            this.Dgv_InventoryItems.Name = "Dgv_InventoryItems";
            this.Dgv_InventoryItems.Size = new System.Drawing.Size(1196, 847);
            this.Dgv_InventoryItems.TabIndex = 32;
            this.Dgv_InventoryItems.Click += new System.EventHandler(this.Dgv_InventoryItems_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1615, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 847);
            this.dataGridView1.TabIndex = 31;
            // 
            // Dgv_SelectedItemInformation
            // 
            this.Dgv_SelectedItemInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SelectedItemInformation.Location = new System.Drawing.Point(9, 105);
            this.Dgv_SelectedItemInformation.Name = "Dgv_SelectedItemInformation";
            this.Dgv_SelectedItemInformation.Size = new System.Drawing.Size(284, 847);
            this.Dgv_SelectedItemInformation.TabIndex = 30;
            // 
            // Btn_UpdateDatabase
            // 
            this.Btn_UpdateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateDatabase.ForeColor = System.Drawing.Color.Teal;
            this.Btn_UpdateDatabase.Location = new System.Drawing.Point(6, 34);
            this.Btn_UpdateDatabase.Name = "Btn_UpdateDatabase";
            this.Btn_UpdateDatabase.Size = new System.Drawing.Size(131, 30);
            this.Btn_UpdateDatabase.TabIndex = 29;
            this.Btn_UpdateDatabase.Text = "Open Item Creator";
            this.Btn_UpdateDatabase.UseVisualStyleBackColor = true;
            this.Btn_UpdateDatabase.Click += new System.EventHandler(this.Btn_UpdateDatabase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1629, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Equipped Item Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Items in Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selected Item Information";
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(1752, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 28);
            this.button13.TabIndex = 13;
            this.button13.Text = "All";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1606, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 28);
            this.button10.TabIndex = 12;
            this.button10.Text = "All";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1460, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(147, 28);
            this.button11.TabIndex = 11;
            this.button11.Text = "All";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(1314, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(147, 28);
            this.button12.TabIndex = 10;
            this.button12.Text = "All";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1168, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 28);
            this.button7.TabIndex = 9;
            this.button7.Text = "All";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1022, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 28);
            this.button8.TabIndex = 8;
            this.button8.Text = "All";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(876, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 28);
            this.button9.TabIndex = 7;
            this.button9.Text = "All";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(730, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "All";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(584, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(438, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(292, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(146, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InventoryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.Tctrl_Inventory);
            this.Name = "InventoryCtrl";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.Load += new System.EventHandler(this.InventoryCtrl_Load);
            this.Tctrl_Inventory.ResumeLayout(false);
            this.Tpg_Inventory1.ResumeLayout(false);
            this.Tpg_Inventory1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InventoryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SelectedItemInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Tctrl_Inventory;
        private System.Windows.Forms.TabPage Tpg_Inventory1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_UpdateDatabase;
        private System.Windows.Forms.DataGridView Dgv_SelectedItemInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView Dgv_InventoryItems;
    }
}
