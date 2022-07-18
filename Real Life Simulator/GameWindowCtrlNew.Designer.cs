namespace Real_Life_Simulator
{
    partial class GameWindowCtrlNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Container = new System.Windows.Forms.Panel();
            this.Btn_MainMenu = new System.Windows.Forms.Button();
            this.Btn_Character = new System.Windows.Forms.Button();
            this.Btn_Inventory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Inventory);
            this.panel1.Controls.Add(this.Btn_MainMenu);
            this.panel1.Controls.Add(this.Btn_Character);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 60);
            this.panel1.TabIndex = 0;
            // 
            // Pnl_Container
            // 
            this.Pnl_Container.BackColor = System.Drawing.Color.Teal;
            this.Pnl_Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Container.Location = new System.Drawing.Point(0, 60);
            this.Pnl_Container.Name = "Pnl_Container";
            this.Pnl_Container.Size = new System.Drawing.Size(1920, 960);
            this.Pnl_Container.TabIndex = 1;
            // 
            // Btn_MainMenu
            // 
            this.Btn_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MainMenu.ForeColor = System.Drawing.Color.White;
            this.Btn_MainMenu.Location = new System.Drawing.Point(-1, -1);
            this.Btn_MainMenu.Name = "Btn_MainMenu";
            this.Btn_MainMenu.Size = new System.Drawing.Size(65, 60);
            this.Btn_MainMenu.TabIndex = 0;
            this.Btn_MainMenu.Text = "Main Menu";
            this.Btn_MainMenu.UseVisualStyleBackColor = true;
            // 
            // Btn_Character
            // 
            this.Btn_Character.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Character.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Character.ForeColor = System.Drawing.Color.White;
            this.Btn_Character.Location = new System.Drawing.Point(63, -1);
            this.Btn_Character.Name = "Btn_Character";
            this.Btn_Character.Size = new System.Drawing.Size(200, 60);
            this.Btn_Character.TabIndex = 1;
            this.Btn_Character.Text = "Character";
            this.Btn_Character.UseVisualStyleBackColor = true;
            this.Btn_Character.Click += new System.EventHandler(this.Btn_Character_Click);
            // 
            // Btn_Inventory
            // 
            this.Btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inventory.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.Btn_Inventory.Location = new System.Drawing.Point(262, -1);
            this.Btn_Inventory.Name = "Btn_Inventory";
            this.Btn_Inventory.Size = new System.Drawing.Size(200, 60);
            this.Btn_Inventory.TabIndex = 2;
            this.Btn_Inventory.Text = "Inventory";
            this.Btn_Inventory.UseVisualStyleBackColor = true;
            // 
            // GameWindowCtrlNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_Container);
            this.Controls.Add(this.panel1);
            this.Name = "GameWindowCtrlNew";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Container;
        private System.Windows.Forms.Button Btn_MainMenu;
        private System.Windows.Forms.Button Btn_Character;
        private System.Windows.Forms.Button Btn_Inventory;
    }
}
