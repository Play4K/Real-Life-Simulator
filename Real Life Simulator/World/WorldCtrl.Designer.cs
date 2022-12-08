
namespace Real_Life_Simulator
{
    partial class WorldCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Supermarket = new System.Windows.Forms.Button();
            this.Txt_RemaningTime = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Tmr_Route = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Pbx_Coordinate = new System.Windows.Forms.PictureBox();
            this.Txt_DistanceInMeters = new System.Windows.Forms.TextBox();
            this.Txt_DistanceCalculation = new System.Windows.Forms.TextBox();
            this.Pnl_Holder = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_DestinationPosition = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_PlayerPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbx_Coordinates = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Coordinate)).BeginInit();
            this.Pnl_Holder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Supermarket
            // 
            this.Btn_Supermarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Supermarket.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supermarket.ForeColor = System.Drawing.Color.Olive;
            this.Btn_Supermarket.Location = new System.Drawing.Point(1619, 1033);
            this.Btn_Supermarket.Name = "Btn_Supermarket";
            this.Btn_Supermarket.Size = new System.Drawing.Size(206, 41);
            this.Btn_Supermarket.TabIndex = 18;
            this.Btn_Supermarket.Text = "Go to Supermarket";
            this.Btn_Supermarket.UseVisualStyleBackColor = true;
            this.Btn_Supermarket.Click += new System.EventHandler(this.Btn_Supermarket_Click);
            // 
            // Txt_RemaningTime
            // 
            this.Txt_RemaningTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_RemaningTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RemaningTime.Location = new System.Drawing.Point(1765, 211);
            this.Txt_RemaningTime.Name = "Txt_RemaningTime";
            this.Txt_RemaningTime.Size = new System.Drawing.Size(154, 33);
            this.Txt_RemaningTime.TabIndex = 27;
            this.Txt_RemaningTime.Text = "00:00:00";
            this.Txt_RemaningTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1612, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 33);
            this.textBox2.TabIndex = 29;
            // 
            // Tmr_Route
            // 
            this.Tmr_Route.Interval = 1000;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1765, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Start.BackColor = System.Drawing.Color.Olive;
            this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Start.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(1612, 176);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(154, 35);
            this.Btn_Start.TabIndex = 25;
            this.Btn_Start.Text = "Start Route";
            this.Btn_Start.UseVisualStyleBackColor = false;
            // 
            // Pbx_Coordinate
            // 
            this.Pbx_Coordinate.BackColor = System.Drawing.Color.White;
            this.Pbx_Coordinate.Location = new System.Drawing.Point(2, 3);
            this.Pbx_Coordinate.Name = "Pbx_Coordinate";
            this.Pbx_Coordinate.Size = new System.Drawing.Size(1607, 1071);
            this.Pbx_Coordinate.TabIndex = 0;
            this.Pbx_Coordinate.TabStop = false;
            this.Pbx_Coordinate.Paint += new System.Windows.Forms.PaintEventHandler(this.Pbx_Coordinate_Paint);
            this.Pbx_Coordinate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pbx_Coordinate_MouseMove);
            this.Pbx_Coordinate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pbx_Coordinate_MouseUp);
            // 
            // Txt_DistanceInMeters
            // 
            this.Txt_DistanceInMeters.Location = new System.Drawing.Point(218, 24);
            this.Txt_DistanceInMeters.Name = "Txt_DistanceInMeters";
            this.Txt_DistanceInMeters.Size = new System.Drawing.Size(74, 25);
            this.Txt_DistanceInMeters.TabIndex = 2;
            // 
            // Txt_DistanceCalculation
            // 
            this.Txt_DistanceCalculation.Location = new System.Drawing.Point(6, 24);
            this.Txt_DistanceCalculation.Name = "Txt_DistanceCalculation";
            this.Txt_DistanceCalculation.Size = new System.Drawing.Size(147, 25);
            this.Txt_DistanceCalculation.TabIndex = 0;
            // 
            // Pnl_Holder
            // 
            this.Pnl_Holder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Holder.AutoScroll = true;
            this.Pnl_Holder.BackColor = System.Drawing.Color.LightGray;
            this.Pnl_Holder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Holder.Controls.Add(this.Pbx_Coordinate);
            this.Pnl_Holder.Location = new System.Drawing.Point(-1, -1);
            this.Pnl_Holder.Name = "Pnl_Holder";
            this.Pnl_Holder.Size = new System.Drawing.Size(1614, 1081);
            this.Pnl_Holder.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "in meter";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1638, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Left time:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.Txt_DistanceInMeters);
            this.groupBox3.Controls.Add(this.Txt_DistanceCalculation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1613, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 60);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distance Calculation";
            // 
            // Txt_DestinationPosition
            // 
            this.Txt_DestinationPosition.Location = new System.Drawing.Point(6, 24);
            this.Txt_DestinationPosition.Name = "Txt_DestinationPosition";
            this.Txt_DestinationPosition.Size = new System.Drawing.Size(286, 25);
            this.Txt_DestinationPosition.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.Txt_DestinationPosition);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1613, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 60);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Position";
            // 
            // Txt_PlayerPosition
            // 
            this.Txt_PlayerPosition.Location = new System.Drawing.Point(6, 24);
            this.Txt_PlayerPosition.Name = "Txt_PlayerPosition";
            this.Txt_PlayerPosition.Size = new System.Drawing.Size(286, 25);
            this.Txt_PlayerPosition.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(1612, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Coordinations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Txt_PlayerPosition);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1612, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 60);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Position";
            // 
            // Lbx_Coordinates
            // 
            this.Lbx_Coordinates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_Coordinates.BackColor = System.Drawing.Color.Brown;
            this.Lbx_Coordinates.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_Coordinates.FormattingEnabled = true;
            this.Lbx_Coordinates.ItemHeight = 21;
            this.Lbx_Coordinates.Items.AddRange(new object[] {
            "X = 4"});
            this.Lbx_Coordinates.Location = new System.Drawing.Point(1613, 277);
            this.Lbx_Coordinates.Name = "Lbx_Coordinates";
            this.Lbx_Coordinates.Size = new System.Drawing.Size(305, 802);
            this.Lbx_Coordinates.TabIndex = 19;
            // 
            // WorldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Btn_Supermarket);
            this.Controls.Add(this.Txt_RemaningTime);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Pnl_Holder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbx_Coordinates);
            this.Name = "WorldCtrl";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.WorldCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Coordinate)).EndInit();
            this.Pnl_Holder.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Supermarket;
        private System.Windows.Forms.TextBox Txt_RemaningTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer Tmr_Route;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.PictureBox Pbx_Coordinate;
        private System.Windows.Forms.TextBox Txt_DistanceInMeters;
        private System.Windows.Forms.TextBox Txt_DistanceCalculation;
        private System.Windows.Forms.Panel Pnl_Holder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_DestinationPosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_PlayerPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Lbx_Coordinates;
    }
}
