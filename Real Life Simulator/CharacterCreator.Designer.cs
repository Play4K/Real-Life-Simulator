
namespace Real_Life_Simulator
{
    partial class CharacterCreator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbx_Gender = new System.Windows.Forms.ListBox();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FirstName = new System.Windows.Forms.TextBox();
            this.Lbx_Characteristics = new System.Windows.Forms.ListBox();
            this.Lbl_Characteristics = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lbl_Characteristics);
            this.panel1.Controls.Add(this.Lbx_Characteristics);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lbx_Gender);
            this.panel1.Controls.Add(this.Btn_CreateCharacter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_LastName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_FirstName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 290);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // Lbx_Gender
            // 
            this.Lbx_Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_Gender.FormattingEnabled = true;
            this.Lbx_Gender.ItemHeight = 19;
            this.Lbx_Gender.Items.AddRange(new object[] {
            "Male"});
            this.Lbx_Gender.Location = new System.Drawing.Point(111, 80);
            this.Lbx_Gender.Name = "Lbx_Gender";
            this.Lbx_Gender.Size = new System.Drawing.Size(150, 42);
            this.Lbx_Gender.TabIndex = 9;
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(111, 242);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(150, 29);
            this.Btn_CreateCharacter.TabIndex = 6;
            this.Btn_CreateCharacter.Text = "Create Character";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = true;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.Btn_CreateCharacter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // Txt_LastName
            // 
            this.Txt_LastName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LastName.Location = new System.Drawing.Point(111, 47);
            this.Txt_LastName.Name = "Txt_LastName";
            this.Txt_LastName.Size = new System.Drawing.Size(150, 26);
            this.Txt_LastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // Txt_FirstName
            // 
            this.Txt_FirstName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FirstName.Location = new System.Drawing.Point(111, 17);
            this.Txt_FirstName.Name = "Txt_FirstName";
            this.Txt_FirstName.Size = new System.Drawing.Size(150, 26);
            this.Txt_FirstName.TabIndex = 0;
            // 
            // Lbx_Characteristics
            // 
            this.Lbx_Characteristics.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_Characteristics.FormattingEnabled = true;
            this.Lbx_Characteristics.ItemHeight = 19;
            this.Lbx_Characteristics.Items.AddRange(new object[] {
            "Truthfull",
            "Lying",
            "Intelligent",
            "Kind",
            "Helpful",
            "Soft",
            "Strong"});
            this.Lbx_Characteristics.Location = new System.Drawing.Point(111, 128);
            this.Lbx_Characteristics.Name = "Lbx_Characteristics";
            this.Lbx_Characteristics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lbx_Characteristics.Size = new System.Drawing.Size(150, 99);
            this.Lbx_Characteristics.TabIndex = 11;
            // 
            // Lbl_Characteristics
            // 
            this.Lbl_Characteristics.AutoSize = true;
            this.Lbl_Characteristics.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Characteristics.Location = new System.Drawing.Point(20, 128);
            this.Lbl_Characteristics.Name = "Lbl_Characteristics";
            this.Lbl_Characteristics.Size = new System.Drawing.Size(77, 38);
            this.Lbl_Characteristics.TabIndex = 12;
            this.Lbl_Characteristics.Text = "Character\r\n-istics";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 17);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(368, 210);
            this.label2.TabIndex = 13;
            this.label2.Text = "This is a test";
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "CharacterCreator";
            this.Size = new System.Drawing.Size(670, 298);
            this.Load += new System.EventHandler(this.CharacterCreator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FirstName;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Lbx_Gender;
        private System.Windows.Forms.Label Lbl_Characteristics;
        private System.Windows.Forms.ListBox Lbx_Characteristics;
        private System.Windows.Forms.Label label2;
    }
}
