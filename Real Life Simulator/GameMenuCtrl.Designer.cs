﻿
namespace Real_Life_Simulator
{
    partial class Btn_Settings
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
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_ExitGame = new System.Windows.Forms.Button();
            this.Btn_StartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Olive;
            this.button2.Location = new System.Drawing.Point(873, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_ExitGame
            // 
            this.Btn_ExitGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_ExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExitGame.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExitGame.ForeColor = System.Drawing.Color.Brown;
            this.Btn_ExitGame.Location = new System.Drawing.Point(873, 491);
            this.Btn_ExitGame.Name = "Btn_ExitGame";
            this.Btn_ExitGame.Size = new System.Drawing.Size(200, 50);
            this.Btn_ExitGame.TabIndex = 1;
            this.Btn_ExitGame.Text = "Exit Game";
            this.Btn_ExitGame.UseVisualStyleBackColor = false;
            this.Btn_ExitGame.Click += new System.EventHandler(this.Btn_ExitGame_Click);
            // 
            // Btn_StartGame
            // 
            this.Btn_StartGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StartGame.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StartGame.ForeColor = System.Drawing.Color.Olive;
            this.Btn_StartGame.Location = new System.Drawing.Point(873, 379);
            this.Btn_StartGame.Name = "Btn_StartGame";
            this.Btn_StartGame.Size = new System.Drawing.Size(200, 50);
            this.Btn_StartGame.TabIndex = 0;
            this.Btn_StartGame.Text = "Start Game";
            this.Btn_StartGame.UseVisualStyleBackColor = false;
            this.Btn_StartGame.Click += new System.EventHandler(this.Btn_StartGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1761, 1047);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Debug Menu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_ExitGame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_StartGame);
            this.Name = "Btn_Settings";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_StartGame;
        private System.Windows.Forms.Button Btn_ExitGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
