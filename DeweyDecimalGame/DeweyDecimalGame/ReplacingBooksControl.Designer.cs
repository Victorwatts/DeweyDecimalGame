
namespace DeweyDecimalGame
{
    partial class ReplacingBooksControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EndGame = new System.Windows.Forms.Button();
            this.lbl_levelHeader = new System.Windows.Forms.Label();
            this.lbl_XPvalue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_GameMode = new System.Windows.Forms.Label();
            this.PB_XP = new System.Windows.Forms.ProgressBar();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_XP = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(18, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 137);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(168, 169);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 277);
            this.listBox2.TabIndex = 4;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(114, 120);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(30, 33);
            this.lbl_Score.TabIndex = 6;
            this.lbl_Score.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_EndGame);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 143);
            this.panel1.TabIndex = 7;
            // 
            // btn_EndGame
            // 
            this.btn_EndGame.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.hazard_sign;
            this.btn_EndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EndGame.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EndGame.Location = new System.Drawing.Point(638, 3);
            this.btn_EndGame.Name = "btn_EndGame";
            this.btn_EndGame.Size = new System.Drawing.Size(190, 137);
            this.btn_EndGame.TabIndex = 4;
            this.btn_EndGame.Text = "End Game";
            this.btn_EndGame.UseVisualStyleBackColor = true;
            this.btn_EndGame.Click += new System.EventHandler(this.btn_EndGame_Click);
            // 
            // lbl_levelHeader
            // 
            this.lbl_levelHeader.AutoSize = true;
            this.lbl_levelHeader.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_levelHeader.ForeColor = System.Drawing.Color.White;
            this.lbl_levelHeader.Location = new System.Drawing.Point(588, 63);
            this.lbl_levelHeader.Name = "lbl_levelHeader";
            this.lbl_levelHeader.Size = new System.Drawing.Size(65, 33);
            this.lbl_levelHeader.TabIndex = 15;
            this.lbl_levelHeader.Text = "LVL:";
            // 
            // lbl_XPvalue
            // 
            this.lbl_XPvalue.AutoSize = true;
            this.lbl_XPvalue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XPvalue.ForeColor = System.Drawing.Color.White;
            this.lbl_XPvalue.Location = new System.Drawing.Point(61, 63);
            this.lbl_XPvalue.Name = "lbl_XPvalue";
            this.lbl_XPvalue.Size = new System.Drawing.Size(30, 33);
            this.lbl_XPvalue.TabIndex = 14;
            this.lbl_XPvalue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Game Mode:";
            // 
            // lbl_GameMode
            // 
            this.lbl_GameMode.AutoSize = true;
            this.lbl_GameMode.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameMode.ForeColor = System.Drawing.Color.White;
            this.lbl_GameMode.Location = new System.Drawing.Point(495, 9);
            this.lbl_GameMode.Name = "lbl_GameMode";
            this.lbl_GameMode.Size = new System.Drawing.Size(87, 33);
            this.lbl_GameMode.TabIndex = 12;
            this.lbl_GameMode.Text = "None";
            // 
            // PB_XP
            // 
            this.PB_XP.Location = new System.Drawing.Point(135, 68);
            this.PB_XP.Name = "PB_XP";
            this.PB_XP.Size = new System.Drawing.Size(447, 23);
            this.PB_XP.TabIndex = 11;
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvl.ForeColor = System.Drawing.Color.White;
            this.lbl_lvl.Location = new System.Drawing.Point(648, 63);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(30, 33);
            this.lbl_lvl.TabIndex = 10;
            this.lbl_lvl.Text = "0";
            // 
            // lbl_XP
            // 
            this.lbl_XP.AutoSize = true;
            this.lbl_XP.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XP.ForeColor = System.Drawing.Color.White;
            this.lbl_XP.Location = new System.Drawing.Point(12, 63);
            this.lbl_XP.Name = "lbl_XP";
            this.lbl_XP.Size = new System.Drawing.Size(54, 33);
            this.lbl_XP.TabIndex = 9;
            this.lbl_XP.Text = "XP:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(12, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(96, 33);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.lbl_Username);
            this.panel2.Controls.Add(this.lbl_lvl);
            this.panel2.Controls.Add(this.lbl_levelHeader);
            this.panel2.Controls.Add(this.lbl_XP);
            this.panel2.Controls.Add(this.lbl_XPvalue);
            this.panel2.Controls.Add(this.PB_XP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_GameMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 100);
            this.panel2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.card_pickup;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 137);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Answer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DeweyDecimalGame.Properties.Resources.card_play;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(428, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 137);
            this.button3.TabIndex = 3;
            this.button3.Text = "Play Again";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReplacingBooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "ReplacingBooksControl";
            this.Size = new System.Drawing.Size(835, 629);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_levelHeader;
        private System.Windows.Forms.Label lbl_XPvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_GameMode;
        private System.Windows.Forms.ProgressBar PB_XP;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_XP;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_EndGame;
    }
}
