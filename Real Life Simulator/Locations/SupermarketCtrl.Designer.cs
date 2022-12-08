namespace Real_Life_Simulator
{
    partial class SupermarketCtrl
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
            this.Dgv_ShopAvailable = new System.Windows.Forms.DataGridView();
            this.Col_Name_ShopAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type_ShopAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cbx_Selection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Basket = new System.Windows.Forms.DataGridView();
            this.Col_Quantity_Basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name_Basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type_Basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_RemoveSelectedItem = new System.Windows.Forms.Button();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.Btn_Leave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Pic_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ShopAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ShopAvailable
            // 
            this.Dgv_ShopAvailable.ColumnHeadersHeight = 25;
            this.Dgv_ShopAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name_ShopAvailable,
            this.Col_Type_ShopAvailable,
            this.Cost});
            this.Dgv_ShopAvailable.Location = new System.Drawing.Point(27, 86);
            this.Dgv_ShopAvailable.Name = "Dgv_ShopAvailable";
            this.Dgv_ShopAvailable.Size = new System.Drawing.Size(443, 973);
            this.Dgv_ShopAvailable.TabIndex = 0;
            this.Dgv_ShopAvailable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_ShopAvailable_CellMouseDoubleClick);
            // 
            // Col_Name_ShopAvailable
            // 
            this.Col_Name_ShopAvailable.DataPropertyName = "Name";
            this.Col_Name_ShopAvailable.HeaderText = "Name";
            this.Col_Name_ShopAvailable.Name = "Col_Name_ShopAvailable";
            this.Col_Name_ShopAvailable.Width = 200;
            // 
            // Col_Type_ShopAvailable
            // 
            this.Col_Type_ShopAvailable.DataPropertyName = "Type";
            this.Col_Type_ShopAvailable.HeaderText = "Type";
            this.Col_Type_ShopAvailable.Name = "Col_Type_ShopAvailable";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Cbx_Selection
            // 
            this.Cbx_Selection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Selection.FormattingEnabled = true;
            this.Cbx_Selection.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.Cbx_Selection.Location = new System.Drawing.Point(27, 52);
            this.Cbx_Selection.Name = "Cbx_Selection";
            this.Cbx_Selection.Size = new System.Drawing.Size(243, 28);
            this.Cbx_Selection.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selection";
            // 
            // Dgv_Basket
            // 
            this.Dgv_Basket.ColumnHeadersHeight = 25;
            this.Dgv_Basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Quantity_Basket,
            this.Col_Name_Basket,
            this.Col_Type_Basket});
            this.Dgv_Basket.Location = new System.Drawing.Point(530, 86);
            this.Dgv_Basket.Name = "Dgv_Basket";
            this.Dgv_Basket.Size = new System.Drawing.Size(381, 948);
            this.Dgv_Basket.TabIndex = 3;
            // 
            // Col_Quantity_Basket
            // 
            this.Col_Quantity_Basket.DataPropertyName = "Quantity";
            this.Col_Quantity_Basket.HeaderText = "Quantity";
            this.Col_Quantity_Basket.Name = "Col_Quantity_Basket";
            this.Col_Quantity_Basket.Width = 50;
            // 
            // Col_Name_Basket
            // 
            this.Col_Name_Basket.DataPropertyName = "Name";
            this.Col_Name_Basket.HeaderText = "Name";
            this.Col_Name_Basket.Name = "Col_Name_Basket";
            this.Col_Name_Basket.Width = 200;
            // 
            // Col_Type_Basket
            // 
            this.Col_Type_Basket.DataPropertyName = "Type";
            this.Col_Type_Basket.HeaderText = "Type";
            this.Col_Type_Basket.Name = "Col_Type_Basket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(535, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basket";
            // 
            // Btn_RemoveSelectedItem
            // 
            this.Btn_RemoveSelectedItem.BackColor = System.Drawing.Color.White;
            this.Btn_RemoveSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RemoveSelectedItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RemoveSelectedItem.ForeColor = System.Drawing.Color.Olive;
            this.Btn_RemoveSelectedItem.Location = new System.Drawing.Point(917, 86);
            this.Btn_RemoveSelectedItem.Name = "Btn_RemoveSelectedItem";
            this.Btn_RemoveSelectedItem.Size = new System.Drawing.Size(186, 37);
            this.Btn_RemoveSelectedItem.TabIndex = 5;
            this.Btn_RemoveSelectedItem.Text = "Give back selected";
            this.Btn_RemoveSelectedItem.UseVisualStyleBackColor = false;
            this.Btn_RemoveSelectedItem.Click += new System.EventHandler(this.Btn_RemoveSelectedItem_Click);
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.BackColor = System.Drawing.Color.White;
            this.Btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buy.ForeColor = System.Drawing.Color.Olive;
            this.Btn_Buy.Location = new System.Drawing.Point(917, 1022);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(186, 37);
            this.Btn_Buy.TabIndex = 6;
            this.Btn_Buy.Text = "Buy basket items";
            this.Btn_Buy.UseVisualStyleBackColor = false;
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // Btn_Leave
            // 
            this.Btn_Leave.BackColor = System.Drawing.Color.White;
            this.Btn_Leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Leave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Leave.ForeColor = System.Drawing.Color.Olive;
            this.Btn_Leave.Location = new System.Drawing.Point(1731, 3);
            this.Btn_Leave.Name = "Btn_Leave";
            this.Btn_Leave.Size = new System.Drawing.Size(186, 37);
            this.Btn_Leave.TabIndex = 7;
            this.Btn_Leave.Text = "Leave Menu";
            this.Btn_Leave.UseVisualStyleBackColor = false;
            this.Btn_Leave.Click += new System.EventHandler(this.Btn_Leave_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Total cost:"});
            this.listBox1.Location = new System.Drawing.Point(530, 1035);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 24);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(629, 1035);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 24);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "€"});
            this.listBox3.Location = new System.Drawing.Point(881, 1035);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(30, 24);
            this.listBox3.TabIndex = 10;
            // 
            // Pic_Item
            // 
            this.Pic_Item.BackColor = System.Drawing.Color.DimGray;
            this.Pic_Item.Location = new System.Drawing.Point(1351, 167);
            this.Pic_Item.Name = "Pic_Item";
            this.Pic_Item.Size = new System.Drawing.Size(287, 294);
            this.Pic_Item.TabIndex = 11;
            this.Pic_Item.TabStop = false;
            // 
            // SupermarketCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.Pic_Item);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Leave);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.Btn_RemoveSelectedItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_Basket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_Selection);
            this.Controls.Add(this.Dgv_ShopAvailable);
            this.Name = "SupermarketCtrl";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Supermarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ShopAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_ShopAvailable;
        private System.Windows.Forms.ComboBox Cbx_Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Basket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_RemoveSelectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Quantity_Basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name_Basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type_Basket;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.Button Btn_Leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name_ShopAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type_ShopAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.PictureBox Pic_Item;
    }
}
