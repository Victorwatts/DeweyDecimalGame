using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DeweyDecimalGame
{
    public partial class MainMenuForm : Form
    {
        
        public MainMenuForm()
        {
            InitializeComponent();
           
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            UserLoggedBannerControl userLoggedBannerControl = new UserLoggedBannerControl();
            panelChildForm.Controls.Add(userLoggedBannerControl);

        }

        private void btn_ReplacingBooks_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            UserData.GameMode = "Replacing Books";
            ReplacingBooksControl ReplacingBooksControl = new ReplacingBooksControl();
            panelChildForm.Controls.Add(ReplacingBooksControl);
            //lbl_SelectedMode.Text = "Replacing Books";
            PanelVisibility();
            p3.Visible = Visible;
            
            
        }

        private void btn_IdentifyingAreas_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            UserData.GameMode = "Identifying Areas";
            //lbl_SelectedMode.Text = "Identifying Areas";
            PanelVisibility();
            p4.Visible = Visible;
            
           
        }

        private void btn_FindingCallNumbers_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            UserData.GameMode = "Finding Call Numbers";
            //lbl_SelectedMode.Text = "Finding Call Numbers";
            PanelVisibility();
            p5.Visible = Visible;
            
           
        }

        private void btn_GameSettings_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            PanelVisibility();
            p7.Visible = Visible;
        }

        private void btn_CharacterInv_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            PanelVisibility();
            p8.Visible = Visible;
        }

        private void btn_MinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Maximized))
            {
                this.WindowState = FormWindowState.Normal;
            }else
            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PanelVisibility()
        {
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;
            p7.Visible = false;
            p8.Visible = false;
            p9.Visible = false;
            p10.Visible = false;

        }

      
    }
}
