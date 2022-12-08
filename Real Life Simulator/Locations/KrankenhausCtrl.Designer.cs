namespace Real_Life_Simulator
{
    partial class KrankenhausCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrankenhausCtrl));
            this.Pic_Reception = new System.Windows.Forms.PictureBox();
            this.Pic_EmergencyRoom = new System.Windows.Forms.PictureBox();
            this.Pic_Hallway = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmergencyRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hallway)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Reception
            // 
            this.Pic_Reception.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Reception.Location = new System.Drawing.Point(1028, 297);
            this.Pic_Reception.Name = "Pic_Reception";
            this.Pic_Reception.Size = new System.Drawing.Size(235, 577);
            this.Pic_Reception.TabIndex = 0;
            this.Pic_Reception.TabStop = false;
            // 
            // Pic_EmergencyRoom
            // 
            this.Pic_EmergencyRoom.BackColor = System.Drawing.Color.Transparent;
            this.Pic_EmergencyRoom.Location = new System.Drawing.Point(1308, 216);
            this.Pic_EmergencyRoom.Name = "Pic_EmergencyRoom";
            this.Pic_EmergencyRoom.Size = new System.Drawing.Size(593, 703);
            this.Pic_EmergencyRoom.TabIndex = 1;
            this.Pic_EmergencyRoom.TabStop = false;
            // 
            // Pic_Hallway
            // 
            this.Pic_Hallway.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Hallway.Location = new System.Drawing.Point(3, 417);
            this.Pic_Hallway.Name = "Pic_Hallway";
            this.Pic_Hallway.Size = new System.Drawing.Size(531, 457);
            this.Pic_Hallway.TabIndex = 2;
            this.Pic_Hallway.TabStop = false;
            // 
            // KrankenhausCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Pic_Hallway);
            this.Controls.Add(this.Pic_EmergencyRoom);
            this.Controls.Add(this.Pic_Reception);
            this.Name = "KrankenhausCtrl";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmergencyRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hallway)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Reception;
        private System.Windows.Forms.PictureBox Pic_EmergencyRoom;
        private System.Windows.Forms.PictureBox Pic_Hallway;
    }
}
