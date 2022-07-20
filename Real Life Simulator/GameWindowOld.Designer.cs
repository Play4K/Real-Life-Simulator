
namespace Real_Life_Simulator
{
    partial class GameWindowOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindowOld));
            this.Lbl_Balance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Age = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.Pbr_Health = new XanderUI.XUIFlatProgressBar();
            this.Pbr_Hunger = new VerticalProgressBar.VerticalProgressBar();
            this.Pbr_Thirst = new VerticalProgressBar.VerticalProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pn_Map = new System.Windows.Forms.Panel();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tmr_GameTime = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Balance
            // 
            this.Lbl_Balance.AutoSize = true;
            this.Lbl_Balance.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Balance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Balance.Location = new System.Drawing.Point(106, 137);
            this.Lbl_Balance.Name = "Lbl_Balance";
            this.Lbl_Balance.Size = new System.Drawing.Size(18, 19);
            this.Lbl_Balance.TabIndex = 13;
            this.Lbl_Balance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Balance:";
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gender.Location = new System.Drawing.Point(106, 43);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(50, 19);
            this.Lbl_Gender.TabIndex = 6;
            this.Lbl_Gender.Text = "MALE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // Lbl_Age
            // 
            this.Lbl_Age.AutoSize = true;
            this.Lbl_Age.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Age.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Age.Location = new System.Drawing.Point(106, 24);
            this.Lbl_Age.Name = "Lbl_Age";
            this.Lbl_Age.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Age.TabIndex = 4;
            this.Lbl_Age.Text = "AGE";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(106, 5);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.xuiClock1);
            this.panel2.Controls.Add(this.Pbr_Health);
            this.panel2.Controls.Add(this.Pbr_Hunger);
            this.panel2.Controls.Add(this.Pbr_Thirst);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 702);
            this.panel2.TabIndex = 1;
            // 
            // xuiClock1
            // 
            this.xuiClock1.BackColor = System.Drawing.Color.White;
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.Goldenrod;
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.Silver;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(5, 5);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(90, 95);
            this.xuiClock1.TabIndex = 5;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // Pbr_Health
            // 
            this.Pbr_Health.BackColor = System.Drawing.Color.Silver;
            this.Pbr_Health.BarStyle = XanderUI.XUIFlatProgressBar.Style.IOS;
            this.Pbr_Health.BarThickness = 5;
            this.Pbr_Health.CompleteColor = System.Drawing.Color.Crimson;
            this.Pbr_Health.InocmpletedColor = System.Drawing.Color.White;
            this.Pbr_Health.Location = new System.Drawing.Point(149, 156);
            this.Pbr_Health.MaxValue = 100;
            this.Pbr_Health.Name = "Pbr_Health";
            this.Pbr_Health.Size = new System.Drawing.Size(103, 16);
            this.Pbr_Health.TabIndex = 5;
            this.Pbr_Health.Text = "xuiFlatProgressBar1";
            this.Pbr_Health.Value = 50;
            // 
            // Pbr_Hunger
            // 
            this.Pbr_Hunger.BackColor = System.Drawing.Color.LightGray;
            this.Pbr_Hunger.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.Pbr_Hunger.Color = System.Drawing.Color.Goldenrod;
            this.Pbr_Hunger.Location = new System.Drawing.Point(176, 232);
            this.Pbr_Hunger.Maximum = 100;
            this.Pbr_Hunger.Minimum = 0;
            this.Pbr_Hunger.Name = "Pbr_Hunger";
            this.Pbr_Hunger.Size = new System.Drawing.Size(25, 71);
            this.Pbr_Hunger.Step = 10;
            this.Pbr_Hunger.Style = VerticalProgressBar.Styles.Solid;
            this.Pbr_Hunger.TabIndex = 6;
            this.Pbr_Hunger.Value = 50;
            // 
            // Pbr_Thirst
            // 
            this.Pbr_Thirst.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.Pbr_Thirst.Color = System.Drawing.Color.SteelBlue;
            this.Pbr_Thirst.Location = new System.Drawing.Point(202, 232);
            this.Pbr_Thirst.Maximum = 100;
            this.Pbr_Thirst.Minimum = 0;
            this.Pbr_Thirst.Name = "Pbr_Thirst";
            this.Pbr_Thirst.Size = new System.Drawing.Size(25, 71);
            this.Pbr_Thirst.Step = 10;
            this.Pbr_Thirst.Style = VerticalProgressBar.Styles.Solid;
            this.Pbr_Thirst.TabIndex = 5;
            this.Pbr_Thirst.Value = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(27, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 56);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Pn_Map
            // 
            this.Pn_Map.BackColor = System.Drawing.Color.DarkGray;
            this.Pn_Map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pn_Map.BackgroundImage")));
            this.Pn_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pn_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pn_Map.Location = new System.Drawing.Point(722, -1);
            this.Pn_Map.Name = "Pn_Map";
            this.Pn_Map.Size = new System.Drawing.Size(180, 170);
            this.Pn_Map.TabIndex = 2;
            this.Pn_Map.Click += new System.EventHandler(this.Pn_Map_Click);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.SteelBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Black;
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Controls.Add(this.Lbl_Gender);
            this.xuiGradientPanel1.Controls.Add(this.Lbl_Balance);
            this.xuiGradientPanel1.Controls.Add(this.Lbl_Age);
            this.xuiGradientPanel1.Controls.Add(this.Lbl_Name);
            this.xuiGradientPanel1.Controls.Add(this.label6);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(398, -1);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(325, 170);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 15;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.SteelBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.DimGray;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "1";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.Pn_Map);
            this.Controls.Add(this.panel2);
            this.Name = "GameWindow";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Age;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Pn_Map;
        private System.Windows.Forms.Label Lbl_Balance;
        private System.Windows.Forms.Label label3;
        private VerticalProgressBar.VerticalProgressBar Pbr_Thirst;
        private VerticalProgressBar.VerticalProgressBar Pbr_Hunger;
        private XanderUI.XUIFlatProgressBar Pbr_Health;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Tmr_GameTime;
    }
}
