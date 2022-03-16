
namespace DeweyDecimalGame
{
    partial class RockPaperScissorsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PC_Scissors = new System.Windows.Forms.Button();
            this.PC_Paper = new System.Windows.Forms.Button();
            this.PC_Rock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_UserChoice = new System.Windows.Forms.Label();
            this.lbl_PC_Choice = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(12, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 41);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 3;
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Paper.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.paper;
            this.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paper.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paper.Location = new System.Drawing.Point(320, 144);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(130, 130);
            this.Paper.TabIndex = 5;
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Scissors.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.scissors;
            this.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scissors.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scissors.Location = new System.Drawing.Point(581, 144);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(130, 130);
            this.Scissors.TabIndex = 6;
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Rock.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.rock;
            this.Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rock.Location = new System.Drawing.Point(70, 144);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(130, 130);
            this.Rock.TabIndex = 4;
            this.Rock.UseVisualStyleBackColor = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rock Paper Scissors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Your Option: Rock, Paper, Scissors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Computers Pick";
            // 
            // PC_Scissors
            // 
            this.PC_Scissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.PC_Scissors.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.scissors;
            this.PC_Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PC_Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC_Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PC_Scissors.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC_Scissors.Location = new System.Drawing.Point(591, 360);
            this.PC_Scissors.Name = "PC_Scissors";
            this.PC_Scissors.Size = new System.Drawing.Size(130, 130);
            this.PC_Scissors.TabIndex = 11;
            this.PC_Scissors.UseVisualStyleBackColor = false;
            // 
            // PC_Paper
            // 
            this.PC_Paper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.PC_Paper.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.paper;
            this.PC_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PC_Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC_Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PC_Paper.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC_Paper.Location = new System.Drawing.Point(330, 360);
            this.PC_Paper.Name = "PC_Paper";
            this.PC_Paper.Size = new System.Drawing.Size(130, 130);
            this.PC_Paper.TabIndex = 10;
            this.PC_Paper.UseVisualStyleBackColor = false;
            // 
            // PC_Rock
            // 
            this.PC_Rock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.PC_Rock.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.rock;
            this.PC_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PC_Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC_Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PC_Rock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC_Rock.Location = new System.Drawing.Point(80, 360);
            this.PC_Rock.Name = "PC_Rock";
            this.PC_Rock.Size = new System.Drawing.Size(130, 130);
            this.PC_Rock.TabIndex = 9;
            this.PC_Rock.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.lbl_PC_Choice);
            this.panel2.Controls.Add(this.lbl_UserChoice);
            this.panel2.Controls.Add(this.lbl_Result);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Results:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Your Choice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Computers Choice:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ForeColor = System.Drawing.Color.White;
            this.lbl_Result.Location = new System.Drawing.Point(104, 0);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 33);
            this.lbl_Result.TabIndex = 3;
            // 
            // lbl_UserChoice
            // 
            this.lbl_UserChoice.AutoSize = true;
            this.lbl_UserChoice.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserChoice.ForeColor = System.Drawing.Color.White;
            this.lbl_UserChoice.Location = new System.Drawing.Point(182, 33);
            this.lbl_UserChoice.Name = "lbl_UserChoice";
            this.lbl_UserChoice.Size = new System.Drawing.Size(0, 33);
            this.lbl_UserChoice.TabIndex = 4;
            // 
            // lbl_PC_Choice
            // 
            this.lbl_PC_Choice.AutoSize = true;
            this.lbl_PC_Choice.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC_Choice.ForeColor = System.Drawing.Color.White;
            this.lbl_PC_Choice.Location = new System.Drawing.Point(284, 66);
            this.lbl_PC_Choice.Name = "lbl_PC_Choice";
            this.lbl_PC_Choice.Size = new System.Drawing.Size(0, 33);
            this.lbl_PC_Choice.TabIndex = 5;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(703, 33);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(85, 41);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PC_Scissors);
            this.Controls.Add(this.PC_Paper);
            this.Controls.Add(this.PC_Rock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RockPaperScissorsForm";
            this.ShowIcon = false;
            this.Text = "RockPaperScissorsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PC_Scissors;
        private System.Windows.Forms.Button PC_Paper;
        private System.Windows.Forms.Button PC_Rock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_PC_Choice;
        private System.Windows.Forms.Label lbl_UserChoice;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Reset;
    }
}