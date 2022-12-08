namespace Real_Life_Simulator
{
    partial class LocationCtrl
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
            this.Pnl_Location = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pnl_Location
            // 
            this.Pnl_Location.BackColor = System.Drawing.Color.White;
            this.Pnl_Location.Location = new System.Drawing.Point(3, 3);
            this.Pnl_Location.Name = "Pnl_Location";
            this.Pnl_Location.Size = new System.Drawing.Size(1914, 1074);
            this.Pnl_Location.TabIndex = 0;
            // 
            // LocationCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Pnl_Location);
            this.Name = "LocationCtrl";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Location;
    }
}
